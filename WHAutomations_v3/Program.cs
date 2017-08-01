using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WHAutomations_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSize sizeA = new LiquidsSize(1);
            BasicSize sizeA1 = new LiquidsSize(2);
            BasicSize sizeB = new GrosserySize(10, 20, 30);
            BasicSize sizeC = new PiecesSize(1);

            BasicPack packA = new LiquidsPack(sizeA);
            BasicPack packA1 = new LiquidsPack(sizeA1);
            BasicPack packB = new GrosseryPack(sizeB);
            BasicPack packC = new PiecesPack(sizeC);

            var packages = new List<IPackage>
            {
                packA,
                packA1,
                packB,
                packC,
            };

            IProduct productA = new LiquidProduct(ProductCategory.Liquid, "Milk", new LiquidsSize(2));
            IProduct productB = new GrosseryProduct(ProductCategory.Grossery, "Pasta", new GrosserySize(10, 20, 30));
            IProduct productC = new PiecesProduct(ProductCategory.Piece, "Bread", new PiecesSize(1));

            var items = new List<IProduct> { productA, productB, productC };

            var dispatcher = new PackingDispatcher(new PackingLineCoordinator(packages));

            foreach (var product in items)
            {
                Console.WriteLine(product);
                Console.WriteLine();

                var packedProduct = dispatcher.PackProduct(product);

                Console.WriteLine(packedProduct);
                Console.WriteLine();
            }

            Console.Read();

            Debugger.Break();
        }
    }

    

   



}
