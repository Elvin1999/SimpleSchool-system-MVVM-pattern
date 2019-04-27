using SchoolSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.ModelView
{
    public class TeacherViewModel : BaseViewModel
    {
        private List<Teacher> allTeacher;
        public List<Teacher> AllTeacher
        {
            get
            {
                return allTeacher;
            }
            set {

                allTeacher = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AllTeacher"));
            }
        }
    }
}
