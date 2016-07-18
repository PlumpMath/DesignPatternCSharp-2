using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher you = new MyTeacher();
            you.CreateStudentList();
            you.CallStudents();

            var veteran = new VeteranTeacher();
            veteran.CreateStudentList();
            veteran.CallStudents();
            Console.ReadKey();
        }
    }
}
