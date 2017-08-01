using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WHAutomations_v3
{
    public interface IPackageProvider
    {
        IPackage GetPackageFor(IProduct product);
    }

    public class PackageProvider : IPackageProvider
    {
        private readonly IEnumerable<IPackage> _packages;

        public PackageProvider(IEnumerable<IPackage> packages)
        {
            _packages = packages;
        }

        public IPackage GetPackageFor(IProduct product)
        {
            return _packages.SingleOrDefault(p => p.SizeOfPack.Equals(product.SizeOfProduct));
        }
    }
}