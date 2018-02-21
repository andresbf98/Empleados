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

namespace Empleados
{
    /// <summary>
    /// Interaction logic for EmpleadoDetalle.xaml
    /// </summary>
    public partial class EmpleadoDetalle : Window
    {
        public int EmpleadoID { get; set; }


        public EmpleadoDetalle(){
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            empleadoTextBox.Text = EmpleadoID.ToString();
        }
    }
}
