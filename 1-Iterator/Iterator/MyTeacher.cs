using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyTeacher : Teacher
    {
        public override void CreateStudentList()
        {
            studentList = new StudentList(5);
            studentList.add(new Student("赤井亮太", 1));
            studentList.add(new Student("赤羽里美", 2));
            studentList.add(new Student("岡田美央", 2));
            studentList.add(new Student("西森俊介", 1));
            studentList.add(new Student("中ノ森玲菜", 2));
        }
        public override void CallStudents()
        {
            int size = studentList.getLastNum();
            for (int n = 0; n < size; n++)
            {
                Console.WriteLine(studentList.getStudentAt(n).getName());
            }
        }
    }
}
