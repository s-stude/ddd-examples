using System;

namespace WHAutomations_v3
{
    public interface IPackingLine
    {
        IPackedProduct Pack(IProduct product);
    }

    public class LiquidsPackingLine : IPackingLine
    {
        private readonly IPackageProvider _packageProvider;

        public LiquidsPackingLine(IPackageProvider packageProvider)
        {
            _packageProvider = packageProvider;
        }

        public IPackedProduct Pack(IProduct product)
        {
            if(product.ProductCategory != ProductCategory.Liquid)throw new ArgumentException("Can pack liquids only");

            IPackage pack =_packageProvider.GetPackageFor(product);

            if (pack == null)
            {
                throw new InvalidOperationException("Package was not found...");
            }

            return new PackedProduct(product, pack, DateTime.Now, this.GetType().Name);
        }
    }

    public class GrosseryPackingLine : IPackingLine
    {
        private readonly IPackageProvider _packageProvider;

        public GrosseryPackingLine(IPackageProvider packageProvider)
        {
            _packageProvider = packageProvider;
        }

        public IPackedProduct Pack(IProduct product)
        {
            if(product.ProductCategory != ProductCategory.Grossery)throw new ArgumentException("Can pack grossery only");

            IPackage pack = _packageProvider.GetPackageFor(product);

            if (pack == null)
            {
                throw new InvalidOperationException("Package was not found...");
            }

            return new PackedProduct(product, pack, DateTime.Now, this.GetType().Name);
        }
    }

    public class PiecesPackingLine : IPackingLine
    {
        private readonly IPackageProvider _packageProvider;

        public PiecesPackingLine(IPackageProvider packageProvider)
        {
            _packageProvider = packageProvider;
        }

        public IPackedProduct Pack(IProduct product)
        {
            if(product.ProductCategory != ProductCategory.Piece)throw new ArgumentException("Can pack piece only");

            IPackage pack = _packageProvider.GetPackageFor(product);

            if (pack == null)
            {
                throw new InvalidOperationException("Package was not found...");
            }

            return new PackedProduct(product, pack, DateTime.Now, this.GetType().Name);
        }
    }
}