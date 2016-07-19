using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Teacher
    {
        public static void main(String[] args)
        {
            Chairperson chairperson1 = new NewTaro();
            chairperson1.organizeClass();

            Chairperson chairperson2 = new Hanako();
            chairperson2.organizeClass();
        }
    }
}
