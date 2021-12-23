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
            main_form.Children.Add(new introduce_formAdmin());
            
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

        private void Slide(int index)
        {

        }
        
        #region listView_item
        private void checkListView_teacher(int i)
        {
            if(i == 0){
                icon_teacher.Foreground = Brushes.White;
                text_teacher.Foreground = Brushes.White;
            }
            else
            {
                icon_teacher.Foreground = Brushes.Aqua;
                text_teacher.Foreground = Brushes.Aqua;
            }
        }
        private void checkListView_student(int i)
        {
            if(i == 0){
                icon_student.Foreground = Brushes.White;
                text_student.Foreground = Brushes.White;
            }
            else
            {
                icon_student.Foreground = Brushes.Aqua;
                text_student.Foreground = Brushes.Aqua;
            }
        }
        private void checkListView_admin(int i)
        {
            if(i == 0){
                icon_admin.Foreground = Brushes.White;
                text_admin.Foreground = Brushes.White;
            }
            else
            {
                icon_admin.Foreground = Brushes.Aqua;
                text_admin.Foreground = Brushes.Aqua;
            }
        }
        private void checkListView_setting(int i)
        {
            if(i == 0){
                icon_setting.Foreground = Brushes.White;
                text_setting.Foreground = Brushes.White;
            }
            else
            {
                icon_setting.Foreground = Brushes.Aqua;
                text_setting.Foreground = Brushes.Aqua;
            }
        }
        private void checkListView_homePage(int i)
        {
            if (i == 0)
            {
                icon_home.Foreground = Brushes.White;
                text_home.Foreground = Brushes.White;
            }
            else
            {
                icon_home.Foreground = Brushes.Aqua;
                text_home.Foreground = Brushes.Aqua;
            }
        }
        #endregion

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index  = 0;
            index = LV.SelectedIndex;
            MoveCursorMenu(index);
            if (index == 5)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (index == 0)
            {
                checkListView_homePage(1);
                checkListView_teacher(0);
                checkListView_student(0);
                checkListView_admin(0);
                checkListView_setting(0);
                introduce_formAdmin f = new introduce_formAdmin();
                main_form.Children.Clear();
                main_form.Children.Add(f);
            }
            else if(index == 1)
            {
                checkListView_homePage(0);
                checkListView_teacher(1);
                checkListView_student(0);
                checkListView_admin(0);
                checkListView_setting(0);
                teacher_adminForm f = new teacher_adminForm();
                main_form.Children.Clear();
                main_form.Children.Add(f);
               
            }
            else if(index == 2)
            {
                checkListView_homePage(0);
                checkListView_teacher(0);
                checkListView_student(1);
                checkListView_admin(0);
                checkListView_setting(0);
                StudentAdminForm f = new StudentAdminForm();
                main_form.Children.Clear();
                main_form.Children.Add(f);
                
            }
            else if(index == 3)
            {
                checkListView_homePage(0);
                checkListView_teacher(0);
                checkListView_student(0);
                checkListView_admin(1);
                checkListView_setting(0);
                main_form.Children.Clear();
                admin_adminForm f = new admin_adminForm();
                main_form.Children.Add(f);
            }
            else if (index == 4)
            {
                checkListView_homePage(0);
                checkListView_teacher(0);
                checkListView_student(0);
                checkListView_admin(0);
                checkListView_setting(1);
                main_form.Children.Clear();
                setting_adminForm f = new  setting_adminForm();
                main_form.Children.Add(f);
            }
        }
        private void MoveCursorMenu(int index)
        {
            
        }
        #endregion
    }
}
