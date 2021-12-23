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
    /// Interaction logic for Error_form.xaml
    /// </summary>
    public partial class Error_form : Window
    {
        public Error_form()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
