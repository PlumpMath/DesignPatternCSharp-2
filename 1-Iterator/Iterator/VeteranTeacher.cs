using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class VeteranTeacher : Teacher
    {
        private MyStudentList list;

        public override void CallStudents()
        {
            Iterator itr = list.iterator();
            while (itr.hasNext())
            {
                Console.WriteLine(((Student)itr.next()).getName());
            }
        }

        public override void CreateStudentList()
        {
            list = new MyStudentList(3);
            list.add(new Student("中川雄介", 1));
            list.add(new Student("板東恵美", 2));
            list.add(new Student("水島太郎", 1));
        }
    }
}
