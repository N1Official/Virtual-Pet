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
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Interaction logic for user_administration.xaml
    /// </summary>
    public partial class user_administration : Window
    {
        public user_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newuser_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new newuser_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
            Show();
        }
    }
}
