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

namespace QuizProject1.Views.student_mainForm
{
    /// <summary>
    /// Interaction logic for pracExam_form.xaml
    /// </summary>
    public partial class pracExam_form : UserControl
    {
        public class dataGriditems
        {
            public string StepNumber { get; set; }
            public string Requirement { get; set; }
            public string Description { get; set; }

        }
       
        public pracExam_form()
        {
            InitializeComponent();
            List<dataGriditems> items = new List<dataGriditems>();

            
            dataGrid.Foreground = Brushes.Black;
        }
    }
}
