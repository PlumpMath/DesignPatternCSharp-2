using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class CutPrint
    {
        protected abstract void draw(Cuttable hanzai);
        protected abstract void cut(Cuttable hanzai);
        protected abstract void print(Cuttable hanzai);
        protected virtual Cuttable createCuttable()
        {
            return new Wood();
        }
        public void createCutPrint()
        {
            Cuttable hanzai = createCuttable();
            draw(hanzai);
            cut(hanzai);
            print(hanzai);
        }
    }
}
