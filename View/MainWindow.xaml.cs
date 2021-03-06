﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonRules_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new View.Rules();
            rules.Show();
        }

        private void buttonPoints_Click(object sender, RoutedEventArgs e)
        {
            Points points = new Points();
            points.Show();
        }
    }
}
