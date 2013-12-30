using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;


using Microsoft.Phone.Controls;

namespace QuizOfLegends.Pages
{
    public partial class MCQ : PhoneApplicationPage
    {

        private Button sender = null;

        public MCQ()
        {
            InitializeComponent();
            FillComponent();
        }

        private void checkAnswer(object sender, GestureEventArgs e)
        {
            //A.IsEnabled = false;
            //B.IsEnabled = false;
            //C.IsEnabled = false;
            //D.IsEnabled = false;
            if (((Button)sender).Name.ToString().Equals(Lang.LocalizedStrings.getMcqAnswer()))
            {
                ((Button)sender).Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));

            }
            else
            {
                ((Button)sender).Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += new DoWorkEventHandler((s, args) =>
                {
                   System.Threading.Thread.Sleep(500);
                });

            bg.RunWorkerCompleted += (s, a) =>
                {
                    ((Button)sender).Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                    FillComponent();
                    //A.IsEnabled = true;
                    //B.IsEnabled = true;
                    //C.IsEnabled = true;
                    //D.IsEnabled = true;
                };

            bg.RunWorkerAsync();
        }

        private void FillComponent()
        {
            Question.Text = Lang.LocalizedStrings.getMcqQuestion();
            A.Content = Lang.LocalizedStrings.getMcqAnswerA();
            B.Content = Lang.LocalizedStrings.getMcqAnswerB();
            C.Content = Lang.LocalizedStrings.getMcqAnswerC();
            D.Content = Lang.LocalizedStrings.getMcqAnswerD();
            if (this.sender != null)
            {
                sender.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
        }
    }
}