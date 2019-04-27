using SchoolSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.ModelView
{
   public class StudentViewModel : BaseViewModel
    {
        private List<Student> allstudent;
        public List<Student> AllStudent
        {
            get { return allstudent; }
            set
            {
                allstudent = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AllStudents"));
            }
        }
    }
}





