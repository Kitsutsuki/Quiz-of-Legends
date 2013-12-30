using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace QuizOfLegends.Pages
{
    public partial class NewGame : PhoneApplicationPage
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void MCQ(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/MCQ.xaml", UriKind.Relative));
        }

        private void FindChampion(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FindChampion.xaml", UriKind.Relative));
        }

        private void FindSkills(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/FindSkills.xaml", UriKind.Relative));
        }
    }
}