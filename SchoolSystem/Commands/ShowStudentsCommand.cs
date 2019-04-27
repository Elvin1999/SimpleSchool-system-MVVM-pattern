using SchoolSystem.Entities;
using SchoolSystem.ModelView;
using SchoolSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolSystem.Commands
{
    class ShowStudentsCommand : ICommand
    {
        //StudentViewModel StudentVM { get; set; }
        //public ShowStudentsCommand(StudentViewModel StudentVM)
        //{
        //    this.StudentVM = StudentVM;
        //}

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
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
    }
}
