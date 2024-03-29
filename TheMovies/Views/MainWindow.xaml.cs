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

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oversigt_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.Source = new Uri("OversigtWindow.xaml", UriKind.Relative);
        }

        private void Forestillinger_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.Source = new Uri("ForestillingerWindow.xaml", UriKind.Relative);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameWindow.Source = new Uri("StartWindow.xaml", UriKind.Relative);
        }
    }
}
