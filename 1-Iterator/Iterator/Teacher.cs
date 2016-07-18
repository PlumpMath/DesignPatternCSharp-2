using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class Teacher
    {
        protected StudentList studentList;

        public abstract void CreateStudentList();
        public abstract void CallStudents();
    }
}
