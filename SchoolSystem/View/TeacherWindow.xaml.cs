using SchoolSystem.ModelView;
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

namespace SchoolSystem.View
{
    /// <summary>
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public TeacherViewModel TeacherVM { get; set; }
        public TeacherWindow(TeacherViewModel TeacherVM)
        {
            InitializeComponent();
            this.TeacherVM = TeacherVM;
        }
    }
}
