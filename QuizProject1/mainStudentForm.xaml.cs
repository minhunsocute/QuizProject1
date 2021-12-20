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
    /// Interaction logic for mainStudentForm.xaml
    /// </summary>
    public partial class mainStudentForm : Window
    {
        public mainStudentForm()
        {
            InitializeComponent();
            
        }

        private void btn_power_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void change_ListViewHomePage(int i)
        {
            if (i == 0)
            {
                icon_homePage.Foreground = Brushes.Aqua;
                text_homePage.Foreground = Brushes.Aqua;
            }
            else
            {
                icon_homePage.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
                text_homePage.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void change_ListViewExam(int i)
        {
            if (i== 0) {
                icon_exam.Foreground = Brushes.Aqua;
                text_exam.Foreground = Brushes.Aqua;
            }
            else
            {
                icon_exam.Foreground =(Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
                text_exam.Foreground =(Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void change_ListViewIn4(int i)
        {
            if (i == 0)
            {
                icon_in4.Foreground = Brushes.Aqua;
                text_in4.Foreground= Brushes.Aqua;
            }
            else
            {
                icon_in4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8")); 
                text_in4.Foreground= (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void change_ListViewPrac(int i)
        {
            if (i == 0)
            {
                icon_pe.Foreground = Brushes.Aqua;
                text_pe.Foreground = Brushes.Aqua;
            }
            else
            {
                icon_pe.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
                text_pe.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void change_ListViewCmt(int i)
        {
            if (i == 0)
            {
                icon_cmt.Foreground = Brushes.Aqua;
                text_cmt.Foreground = Brushes.Aqua;
            }
            else
            {
                icon_cmt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
                text_cmt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void change_ListViewSetting(int i)
        {
            if (i == 0)
            {
                icon_setting.Foreground = Brushes.Aqua;
                text_setting.Foreground = Brushes.Aqua;
            }
            else
            {
                icon_setting.Foreground =(Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
                text_setting.Foreground =(Brush)(new BrushConverter().ConvertFrom("#FF5164D8"));
            }
        }
        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = 0;
            index = LV.SelectedIndex;
            if (index == 0)
            {
                change_ListViewHomePage(0);
                change_ListViewExam(1);
                change_ListViewIn4(1);
                change_ListViewPrac(1);
                change_ListViewCmt(1);
                change_ListViewSetting(1);
                main_grid.Children.Clear();
                main_grid.Children.Add(new introduce_form());
            }
            else if(index == 1)
            {
                change_ListViewHomePage(1);
                change_ListViewExam(0);
                change_ListViewIn4(1);
                change_ListViewPrac(1);
                change_ListViewCmt(1);
                change_ListViewSetting(1);
                main_grid.Children.Clear();
                
            }
            else if(index == 2)
            {
                change_ListViewHomePage(1);
                change_ListViewExam(1);
                change_ListViewIn4(0);
                change_ListViewPrac(1);
                change_ListViewCmt(1);
                change_ListViewSetting(1);
                main_grid.Children.Clear();
            }
            else if(index == 3)
            {
                change_ListViewHomePage(1);
                change_ListViewExam(1);
                change_ListViewIn4(1);
                change_ListViewPrac(0);
                change_ListViewCmt(1);
                change_ListViewSetting(1);
                main_grid.Children.Clear();
            }
            else if (index == 4)
            {
                change_ListViewHomePage(1);
                change_ListViewExam(1);
                change_ListViewIn4(1);
                change_ListViewPrac(1);
                change_ListViewCmt(0);
                change_ListViewSetting(1);
                main_grid.Children.Clear();
            }
            else if(index == 5)
            {
                change_ListViewHomePage(1);
                change_ListViewExam(1);
                change_ListViewIn4(1);
                change_ListViewPrac(1);
                change_ListViewCmt(1);
                change_ListViewSetting(0);
                main_grid.Children.Clear();
            }

        }
    }
}
