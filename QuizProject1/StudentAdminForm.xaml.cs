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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizProject1
{
    /// <summary>
    /// Interaction logic for StudentAdminForm.xaml
    /// </summary>
    public partial class StudentAdminForm : UserControl
    {
        public StudentAdminForm()
        {
            InitializeComponent();
        }

        private void btn_find_Click_1(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.6;
            EditViewStudent f = new EditViewStudent();
            f.ShowDialog();
            this.Opacity = 1;
        }

        private void btnInsert(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.6;
            InsertStudent f = new InsertStudent();
            f.ShowDialog();
            this.Opacity = 1;
        }
    }
}
