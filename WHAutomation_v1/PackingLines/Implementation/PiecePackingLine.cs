using System;

namespace WHAutomation_v1
{
    public class PiecePackingLine : IPackingLine
    {
        private PackageProvider _packageProvider;

        public PiecePackingLine(PackageProvider packageProvider)
        {
            this._packageProvider = packageProvider;
        }

        public IPackedProduct Pack(IProduct product)
        {
            var package = _packageProvider.GetPackageFor(product.ProductSize);

            return new PackedProduct(product, package, DateTime.Now, this.GetType().FullName);
        }
    }
}