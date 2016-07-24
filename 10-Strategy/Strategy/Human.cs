using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Human
    {
        public String name;
        public int height = -1;
        public int weight = -1;
        public int age = -1;

        public Human(String name, int height, int weight, int age)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }
    }
}
