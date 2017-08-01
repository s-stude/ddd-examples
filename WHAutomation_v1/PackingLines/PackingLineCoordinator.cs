using System;
using System.Collections.Generic;

namespace WHAutomation_v1
{
    public class PackingLineCoordinator : IPackingLineCoordinator
    {
        public IPackingLine GetPackingLineBy(Product product)
        {
            var allLines = GetAllPackingLines();

            IPackingLine line = null;
            //allLines.TryGetValue(product.ProductSize.UnitOfMeasure, out line);

            if (line == null)
            {
                // throw new InvalidOperationException(string.Format("Packing line was not found for {0}", product.ProductSize.UnitOfMeasure));
            }

            return line;
        }

        private Dictionary<UnitOfMeasure, IPackingLine> GetAllPackingLines()
        {
            List<Package> packages = GetPackagesFromStorage();

            var packageProvider = new PackageProvider(packages);

            // TODO: Configurable? 
            return new Dictionary<UnitOfMeasure, IPackingLine>
            {
                {UnitOfMeasure.Piece, new PiecePackingLine(packageProvider)},
                {UnitOfMeasure.Liter, new LiquidsPackingLine(packageProvider)},
                {UnitOfMeasure.Kilo, new GrosseryPackingLine(packageProvider)}
            };
        }

        private List<Package> GetPackagesFromStorage()
        {
            // TODO: database? 
            return new List<Package>
            {
                new PiecePackage("Corp1", new PieceSize(UnitOfMeasure.Piece)),
                new PiecePackage("Corp1", new PieceSize(UnitOfMeasure.Piece)),

                new LiquidsPackage("Corp1", new LiquidsSize(UnitOfMeasure.Liter, 0.5)),
                new LiquidsPackage("Corp1", new LiquidsSize(UnitOfMeasure.Liter, 1)),

                new ThreeDPackage("Corp1", new ThreeDSize(UnitOfMeasure.Kilo, 100, 200, 300)),
                new ThreeDPackage("Corp1", new ThreeDSize(UnitOfMeasure.Kilo, 200, 400, 600)),
                new ThreeDPackage("Corp1", new ThreeDSize(UnitOfMeasure.Kilo, 400, 600, 800)),
            };

        }
    }
}