using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WHAutomation_v1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var milk = new LiquidProduct("Milk", new LiquidsSize(UnitOfMeasure.Liter, 0.5));
            var bread = new PieceProduct("Bread", new PieceSize(UnitOfMeasure.Piece));
            var pasta = new ThreeDProduct("Ravioli", new ThreeDSize(UnitOfMeasure.Kilo, 100, 200, 300));

            var items = new List<Product> { milk, bread, pasta };

            var dispatcher = new PackingDispatcher(new PackingLineCoordinator());

            foreach (var product in items)
            {
                Console.WriteLine(product);
                Console.WriteLine();
                var packedProduct = dispatcher.PackProduct(product);

                Console.WriteLine(packedProduct);
                Console.WriteLine();
            }

            Console.Read();

            

        }
    }

}