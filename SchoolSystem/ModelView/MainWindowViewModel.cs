using SchoolSystem.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.ModelView
{
    public class MainWindowViewModel:BaseViewModel
    {
        //public ShowStudentsCommand ShowStudents { get; set; }

        //public MainWindowViewModel()
        //{
        //    ShowStudents = new ShowStudentsCommand();
        //}

        public ShowStudentsCommand ShowStudents => new ShowStudentsCommand();

    }
}
