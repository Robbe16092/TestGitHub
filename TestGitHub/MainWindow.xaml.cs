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

namespace TestGitHub
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je klikte op Kathleen Geuens");
        }

        private void Waterman_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ik zen de waterman");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Je klikte op de Husky");

            MessageBox.Show("Fix mij viraal gaan op SoundCloud door mijn muziek te gebruiken op TikTok XD, SoundCloud.comZJEF");

        }
    }
}
