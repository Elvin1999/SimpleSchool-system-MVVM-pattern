using SchoolSystem.Entities;
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

namespace SchoolSystem
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

        private void ShowStudent_Click(object sender, RoutedEventArgs e)
        {
            List<Student> Students = new List<Student>()
            {
                {
                    new Student()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",

                    }
                }
            }
        }

        private void Showteacher_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
