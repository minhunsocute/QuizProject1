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
            System.Windows.Application.Current.Shutdown();
        }

        
       
        private void btnTeaCher_MouseEnter(object sender, MouseEventArgs e)
        {
            btnTeaCher.Background = Brushes.Transparent;
        }

        private void btnShutDown_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if(tg_btn.IsChecked == true)
            {
                tl_teacher.Visibility = Visibility.Collapsed;
                tl_student.Visibility = Visibility.Collapsed;
                tl_admin.Visibility = Visibility.Collapsed;
                tl_shutdown.Visibility = Visibility.Collapsed;  
            }
            else
            {
                tl_shutdown.Visibility = Visibility.Visible;
                tl_student.Visibility= Visibility.Visible;  
                tl_teacher.Visibility= Visibility.Visible;
                tl_admin.Visibility= Visibility.Visible;
            }
        }
        

        private void tg_btn_Checked(object sender, RoutedEventArgs e)
        {
            nav_info.Opacity = 0.3;
        }

        private void tg_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            nav_info.Opacity = 1;
        }

        private void btnTeaCher_Checked(object sender, RoutedEventArgs e)
        {
            teacherText.Foreground = Brushes.Black;
            btnAdmin.IsChecked = false;
            btnShutDown.IsChecked = false;
            btnStudent.IsChecked = false;
            tg_btn.IsChecked = false;
        }
        
        private void btnTeaCher_Unchecked(object sender, RoutedEventArgs e)
        {
            teacherText.Foreground = Brushes.White;
        }

        private void btnStudent_Checked(object sender, RoutedEventArgs e)
        {
            studenttext.Foreground = Brushes.Black;
            btnTeaCher.IsChecked = false;
            btnShutDown.IsChecked=false;
            btnAdmin.IsChecked=false;
            tg_btn.IsChecked =false;
        }

        private void btnStudent_Unchecked(object sender, RoutedEventArgs e)
        {
            studenttext.Foreground= Brushes.White;  
        }

        private void btnAdmin_Unchecked(object sender, RoutedEventArgs e)
        {
            admintext.Foreground = Brushes.White;
        }

        private void btnAdmin_Checked(object sender, RoutedEventArgs e)
        {
            admintext.Foreground = Brushes.Black;
            btnTeaCher.IsChecked=false;
            btnStudent.IsChecked=false;
            tg_btn.IsChecked =false;
        }
        #endregion
    }
}
