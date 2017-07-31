using System;
using System.Collections.Generic;
using System.Linq;

namespace WHAutomation_v1
{
    public class PackageProvider : IPackageProvider
    {
        private readonly IEnumerable<IPackage> _packages;

        public PackageProvider()
        {
            _packages = new List<IPackage>();
        }

        public PackageProvider(IEnumerable<IPackage> packages) : this()
        {
            _packages = packages;
        }

        public IPackage GetPackageFor(ProductSize productSize)
        {
            IEnumerable<IPackage> availablePackages = GetPacksFor(productSize.UnitOfMeasure).ToList();

            if (availablePackages.Any() == false)
            {
                throw new InvalidOperationException(string.Format("There are no available packages for {0}",
                    productSize.UnitOfMeasure));
            }

            var pack = availablePackages
                .Where(p => Math.Abs(p.PackageSize.Volume - productSize.Amount) < 0.05) // TODO: Fix this
                .OrderBy(p => p.PackageSize.Volume)
                .FirstOrDefault();

            if(pack == null)throw new InvalidOperationException(string.Format("Pack not found for {0}", productSize.UnitOfMeasure));

            return pack;
        }

        private IEnumerable<IPackage> GetPacksFor(UnitOfMeasure unitOfMeasure)
        {
            return _packages.Where(p => p.PackageSize.UnitOfMeasure == unitOfMeasure);
        }
    }
}