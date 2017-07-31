namespace WHAutomation_v1
{
    public interface IPackage
    {
        string Manufacturer { get; }
        PackageSize PackageSize { get; }
    }
}