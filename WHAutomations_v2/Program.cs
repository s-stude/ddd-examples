using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAutomations_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSize sizeA = new SizeA (1);
            BasicSize sizeB = new SizeB(10, 20, 30);
            BasicSize sizeC = new SizeC(1);

            BasicPack packA = new PackA(sizeA);
            BasicPack packB = new PackB(sizeB);
            BasicPack packC = new PackC(sizeC);

            BasicProduct productA = new ProductA(new SizeA(2));
            BasicProduct productB = new ProductB(new SizeB(10, 20, 30));
            BasicProduct productC = new ProductC(new SizeC(1));

            var packAfitsProductA = packA.Fits(productA);
            var packAfitsProductB = packB.Fits(productB);
            var packAfitsProductC = packC.Fits(productC);

            Debugger.Break();
        }
    }



   



}
