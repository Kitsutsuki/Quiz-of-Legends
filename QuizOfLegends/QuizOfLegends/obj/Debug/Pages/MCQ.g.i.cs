﻿#pragma checksum "C:\Users\Sara\Documents\Programmation\C#\QuizOfLegends\QuizOfLegends\Pages\MCQ.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65EB26693D4796BFEF514D76088D818F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18051
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace QuizOfLegends.Pages {
    
    
    public partial class MCQ : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock Question;
        
        internal System.Windows.Controls.Button A;
        
        internal System.Windows.Controls.Button B;
        
        internal System.Windows.Controls.Button C;
        
        internal System.Windows.Controls.Button D;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/QuizOfLegends;component/Pages/MCQ.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Question = ((System.Windows.Controls.TextBlock)(this.FindName("Question")));
            this.A = ((System.Windows.Controls.Button)(this.FindName("A")));
            this.B = ((System.Windows.Controls.Button)(this.FindName("B")));
            this.C = ((System.Windows.Controls.Button)(this.FindName("C")));
            this.D = ((System.Windows.Controls.Button)(this.FindName("D")));
        }
    }
}

