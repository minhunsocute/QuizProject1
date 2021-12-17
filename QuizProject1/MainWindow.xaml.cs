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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            //System.Windows.Application.Current.Shutdown();
        }


        #region events Click
        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        
        
       

        private void tg_btn_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void tg_btn_Unchecked(object sender, RoutedEventArgs e)
        {
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index  = 0;
            index = LV.SelectedIndex;
            MoveCursorMenu(index);
            if (index == 3)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (index == 0)
            {
                btn_teacher.Background = Brushes.Purple;
                btn_student.Background = Brushes.Transparent;
                btn_admin.Background = Brushes.Transparent;
                teacher_adminForm f = new teacher_adminForm();
                main_form.Children.Clear();
                main_form.Children.Add(f);
            }
            else if(index == 1)
            {
                btn_teacher.Background = Brushes.Transparent;
                btn_student.Background = Brushes.Purple;
                btn_admin.Background = Brushes.Transparent;
                main_form.Children.Clear(); 
            }
            else if(index == 2)
            {
                btn_teacher.Background = Brushes.Transparent;
                btn_student.Background = Brushes.Transparent;
                btn_admin.Background = Brushes.Purple;
                main_form.Children.Clear();
            }
        }
        private void MoveCursorMenu(int index)
        {
            
        }
        #endregion
    }
}
