using System;
using System.Collections.Generic;

namespace WHAutomation_v1
{
    public class PackingLineCoordinator : IPackingLineCoordinator
    {
        public IPackingLine GetPackingLineBy(IProduct product)
        {
            var allLines = GetAllPackingLines();

            IPackingLine line;
            allLines.TryGetValue(product.ProductSize.UnitOfMeasure, out line);

            if (line == null)
            {
                throw new InvalidOperationException(string.Format("Packing line was not found for {0}",
                    product.ProductSize.UnitOfMeasure));
            }

            return line;
        }

        private Dictionary<UnitOfMeasure, IPackingLine> GetAllPackingLines()
        {
            List<IPackage> packages = GetPackagesFromStorage();

            var packageProvider = new PackageProvider(packages);

            // TODO: Configurable? 
            return new Dictionary<UnitOfMeasure, IPackingLine>
            {
                {UnitOfMeasure.Piece, new PiecePackingLine(packageProvider)},
                {UnitOfMeasure.Liter, new LiquidsPackingLine(packageProvider)},
                {UnitOfMeasure.Kilo, new GrosseryPackingLine(packageProvider)}
            };
        }

        private List<IPackage> GetPackagesFromStorage()
        {
            // TODO: database? 
            return new List<IPackage>
            {
                new Package("Corp1", new PackageSize(UnitOfMeasure.Piece, 1)),
                new Package("Corp1", new PackageSize(UnitOfMeasure.Piece, 2)),

                new Package("Corp1", new PackageSize(UnitOfMeasure.Liter, 0.5)),
                new Package("Corp1", new PackageSize(UnitOfMeasure.Liter, 1)),

                new Package("Corp1", new PackageSize(UnitOfMeasure.Kilo, 0.25)),
                new Package("Corp1", new PackageSize(UnitOfMeasure.Kilo, 1)),
                new Package("Corp1", new PackageSize(UnitOfMeasure.Kilo, 2)),
            };

        }
    }
}