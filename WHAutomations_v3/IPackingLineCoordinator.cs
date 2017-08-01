using System;
using System.Collections.Generic;

namespace WHAutomations_v3
{
    public interface IPackingLineCoordinator
    {
        IPackingLine GetPackingLineBy(IProduct product);
    }

    public class PackingLineCoordinator : IPackingLineCoordinator
    {
        private readonly List<IPackage> _packages;

        public PackingLineCoordinator(List<IPackage> packages)
        {
            _packages = packages;
        }

        public IPackingLine GetPackingLineBy(IProduct product)
        {
            var allLines = GetAllLines();

            IPackingLine line;
            allLines.TryGetValue(product.ProductCategory, out line);

            if (line == null)
            {
                throw new InvalidOperationException(string.Format("Packing line was not found for {0}", product.ProductCategory));
            }

            return line;

        }

        private Dictionary<ProductCategory, IPackingLine> GetAllLines()
        {
            var packageProvider = new PackageProvider(_packages);

            return new Dictionary<ProductCategory, IPackingLine>
            {
                {ProductCategory.Piece, new PiecesPackingLine(packageProvider)},
                {ProductCategory.Liquid, new LiquidsPackingLine(packageProvider)},
                {ProductCategory.Grossery, new GrosseryPackingLine(packageProvider)}
            };
        }

        private List<IPackage> GetPackagesFromStorage()
        {
            BasicSize sizeA = new LiquidsSize(1);
            BasicSize sizeB = new GrosserySize(10, 20, 30);
            BasicSize sizeC = new PiecesSize(1);

            BasicPack packA = new LiquidsPack(sizeA);
            BasicPack packB = new GrosseryPack(sizeB);
            BasicPack packC = new PiecesPack(sizeC);

            return new List<IPackage>
            {
                packA,
                packB,
                packC,
            };
        }
    }
}