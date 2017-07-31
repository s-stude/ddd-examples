using System;
using System.Collections.Generic;

namespace WHAutomation_v1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var milk = new Product("Milk", new ProductSize(0.5, UnitOfMeasure.Liter));
            var bread = new Product("Bread", new ProductSize(1, UnitOfMeasure.Piece));
            var pasta = new Product("Ravioli", new ProductSize(0.25, UnitOfMeasure.Kilo));

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