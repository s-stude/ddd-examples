using System;
using System.Collections.Generic;
using System.Linq;

namespace WHAutomation_v1
{
    public class PackageProvider : IPackageProvider
    {
        private readonly IEnumerable<Package<ProductSize>> _packages;

        public PackageProvider()
        {
            _packages = new List<Package<ProductSize>>();
        }

        public PackageProvider(IEnumerable<Package<ProductSize>> packages) : this()
        {
            _packages = packages;
        }

        public IPackage<ProductSize> GetPackageFor(ProductSize productSize)
        {
            IEnumerable<Package<ProductSize>> availablePackages = GetPacksFor(productSize).ToList();

            if (availablePackages.Any() == false)
            {
                throw new InvalidOperationException(string.Format("There are no available packages for {0}",
                    productSize.UnitOfMeasure));
            }

            var pack = availablePackages.FirstOrDefault(p => p.FitProductSize(productSize));

            if(pack == null)throw new InvalidOperationException(string.Format("Pack not found for {0}", productSize.UnitOfMeasure));

            return pack;
        }

        private IEnumerable<Package<ProductSize>> GetPacksFor(ProductSize productSize)
        {
            return _packages.Where(p => p.PackageSize.UnitOfMeasure == productSize);
        }
    }
}