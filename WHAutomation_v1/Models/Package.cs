namespace WHAutomation_v1
{
    public class Package : IPackage
    {
        public string Manufacturer { get; }
        public PackageSize PackageSize { get; }

        public Package(string manufacturer, PackageSize packageSize)
        {
            Manufacturer = manufacturer;
            PackageSize = packageSize;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, PackageSize: {PackageSize}";
        }
    }
}