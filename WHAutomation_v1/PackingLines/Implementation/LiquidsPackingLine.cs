using System;

namespace WHAutomation_v1
{
    public class LiquidsPackingLine : IPackingLine
    {
        private readonly IPackageProvider _packageProvider;

        public LiquidsPackingLine(IPackageProvider packageProvider)
        {
            _packageProvider = packageProvider;
        }

        public IPackedProduct Pack(IProduct product)
        {
            var package = _packageProvider.GetPackageFor(product.ProductSize);
            package.PackageSize.FitProduct(product);

            return new PackedProduct(product, package, DateTime.Now, this.GetType().FullName);
        }
    }
}