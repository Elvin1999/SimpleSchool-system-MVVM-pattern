using SchoolSystem.Entities;
using SchoolSystem.ModelView;
using SchoolSystem.View;
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
                    new Student()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },
                     new Student()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },
                      new Student()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },

                };
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.AllStudent = Students;
            StudentWindow studentWindow = new StudentWindow(studentViewModel);
            studentWindow.ShowDialog();
            
        }

        private void Showteacher_Click(object sender, RoutedEventArgs e)
        {
            List<Teacher> Teachers = new List<Teacher>()
            {
                    new Teacher()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },
                     new Teacher()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },
                      new Teacher()
                    {
                        Id=Guid.NewGuid(),
                        Name="Anar",
                        Surname="Ehmedov",
                        Age=20
                    },
                };
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.AllTeacher = Teachers;
            TeacherWindow teacherWindow = new TeacherWindow(teacherViewModel);
            teacherWindow.ShowDialog();
        }
    }
}
