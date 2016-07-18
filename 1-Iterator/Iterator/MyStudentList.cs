using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyStudentList : StudentList, Aggregate
    {
        public MyStudentList()
            : base()
        {
        }
        public MyStudentList(int studentCount)
            : base(studentCount)
        {
        }

        public Iterator iterator()
        {
            return new MyStudentListIterator(this);
        }
    }
}
