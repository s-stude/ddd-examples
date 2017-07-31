namespace WHAutomation_v1
{
    public interface IPackageProvider
    {
        IPackage GetPackageFor(ProductSize productSize);
    }
}