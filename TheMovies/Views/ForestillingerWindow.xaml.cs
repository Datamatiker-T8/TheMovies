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

namespace TheMovies.Views
{
    /// <summary>
    /// Interaction logic for ForestillingerWindow.xaml
    /// </summary>
    public partial class ForestillingerWindow : Page
    {
        public ForestillingerWindow()
        {
            InitializeComponent();
        }

        private void AddShow_btn_Click(object sender, RoutedEventArgs e)
        {
            AddShow addShow = new AddShow();
            if (addShow.ShowDialog() == true)
            {

            }
        }
    }
}
