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

namespace QuizProject1
{
    /// <summary>
    /// Interaction logic for teacher_adminForm.xaml
    /// </summary>
    public partial class teacher_adminForm : UserControl
    {
        public teacher_adminForm()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.6;
            InsertTea f = new InsertTea();
            f.ShowDialog();
            this.Opacity = 1;
        }

    }
}
