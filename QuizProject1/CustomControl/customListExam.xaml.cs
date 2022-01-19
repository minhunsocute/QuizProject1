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

namespace QuizProject1.CustomControl
{
    /// <summary>
    /// Interaction logic for customListExam.xaml
    /// </summary>
    public partial class customListExam : UserControl
    {
        public customListExam()
        {
            InitializeComponent();
            DataContext = new MyFilesViewModel();
            
        }
        public PathGeometry FileThumb
        {
            get { return (PathGeometry)GetValue(FileThumbProperty); }
            set { SetValue(FileThumbProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileThumb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileThumbProperty =
            DependencyProperty.Register("FileThumb", typeof(PathGeometry), typeof(customListExam));

    }
}
