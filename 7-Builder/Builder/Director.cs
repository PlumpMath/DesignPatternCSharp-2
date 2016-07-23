using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void constract()
        {
            builder.addSolvent(100);
            builder.addSolute(40);
            builder.abandonSolution(70);
            builder.addSolvent(100);
            builder.addSolute(15);
        }
    }
}
