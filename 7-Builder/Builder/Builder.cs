using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface Builder
    {
        void addSolute(double soluteAmount);
        void addSolvent(double solventAmount);
        void abandonSolution(double solutionAmount);
        Object getResult();
    }
}
