using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyStudentListIterator : Iterator
    {
        private MyStudentList myStudentList;
        private int index;

        public MyStudentListIterator(MyStudentList list)
        {
            this.myStudentList = list;
            this.index = 0;
        }

        public bool hasNext()
        {
            if (myStudentList.getLastNum() > index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object next()
        {
            Student s = myStudentList.getStudentAt(index);
            index++;
            return s;
        }
    }
}
