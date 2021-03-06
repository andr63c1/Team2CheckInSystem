﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CheckInSystem
{
    /// <summary>
    /// Interaction logic for EmployeeWelcomeWindow.xaml
    /// </summary>
    public partial class EmployeeWelcomeWindow : Window
    {
        public EmployeeWelcomeWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
            this.Close();
        }
    }
}
