using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace QuizOfLegends.Lang
{
    public class LocalizedStrings
    {
        private static List<int> remainingQ = new List<int>();
        private static int index = 0;

        public LocalizedStrings()
        {
            for (int i = 1; i <= 10; i++)
            {
                remainingQ.Add(i);
            }
        }

        private static AppResources localizedResources = new AppResources();

        public AppResources AppResources
        {
            get { return localizedResources; }
        }

        public static String getMcqQuestion()
        {
            if (remainingQ.Count > 0)
            {
                index = remainingQ[new Random().Next(remainingQ.Count)];
                remainingQ.Remove(index);
                return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString(), AppResources.Culture);
            }
            else
            {
                return null;
            }
        }

        public static String getMcqAnswerA()
        {
            return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString() + "_A", AppResources.Culture);
        }

        public static String getMcqAnswerB()
        {
            return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString() + "_B", AppResources.Culture);
        }

        public static String getMcqAnswerC()
        {
            return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString() + "_C", AppResources.Culture);
        }

        public static String getMcqAnswerD()
        {
            return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString() + "_D", AppResources.Culture);
        }

        public static String getMcqAnswer()
        {
            return AppResources.ResourceManager.GetString("MCQ_Q" + index.ToString() + "_R", AppResources.Culture);
        }
    }
}