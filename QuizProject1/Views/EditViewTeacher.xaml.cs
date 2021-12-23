using System;
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

namespace QuizProject1
{
    /// <summary>
    /// Interaction logic for EditViewTeacher.xaml
    /// </summary>
    public partial class EditViewTeacher : Window
    {
        public EditViewTeacher()
        {
            InitializeComponent();
        }

        private void btn_shutdown_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.6;
            Error_form f= new Error_form();
            f.ShowDialog();
            this.Opacity = 1;
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.6;
            Success_form f = new Success_form();
            f.ShowDialog();
            this.Opacity= 1;
        }
    }
}
