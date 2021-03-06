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

namespace WPF_Binding
{

    /// <summary>
    /// Interaction logic for SingleObject.xaml
    /// </summary>
    public partial class SingleObject : Window
    {

        private Person _person { get; set; }

        public SingleObject()
        {
            InitializeComponent();
            _person = new Person { Name = "Noah", Age = 19};
            DataContext = _person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clickEvent_btn_Click(object sender, RoutedEventArgs e)
        {
            _person.Age++;
        }
    }
}
