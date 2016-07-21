using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ImagawasCutPrint : CutPrint
    {
        protected override void draw(Cuttable hanzai)
        {
            Console.WriteLine("マンガの絵を描く");
        }
        protected override void cut(Cuttable hanzai)
        {
            Console.WriteLine("彫刻刀を利用して器用に彫る");
        }
        protected override void print(Cuttable hanzai)
        {
            Console.WriteLine("インクとして、自分の血を使いプリントする");
        }
        protected override Cuttable createCuttable()
        {
            return new Potato();
        }
    }
}
