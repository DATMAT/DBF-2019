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

namespace GUI_DBF_2019_
{
    /// <summary>
    /// Interaction logic for UCAddBook.xaml
    /// </summary>
    public partial class UCAddBook : UserControl
    {
        public UCAddBook()
        {
            InitializeComponent();
        }

        private void ISBN_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TitelEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReleasedateEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForfatterEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Forfatter UCEditWriter = new UCEdit_Forfatter();
            
        }

        private void ForlagEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenreEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TypeEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IndkøbEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}