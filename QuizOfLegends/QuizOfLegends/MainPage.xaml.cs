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

namespace QuizOfLegends
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
        }

        private void NewGame(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/NewGame.xaml", UriKind.Relative));
        }

        private void Continue(object sender, GestureEventArgs e)
        {
            // Sara : Chargement des données de la base de données
            // Sara : Lancement de la sauvegarde utilisateur
        }

        private void Settings(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("./Pages/Settings.xaml", UriKind.Relative));
        }

        private void Quit(object sender, GestureEventArgs e)
        {
        }
    }
}