namespace WHAutomation_v1
{
    public interface IPackageProvider
    {
        IPackage<ProductSize> GetPackageFor(ProductSize productSize);
    }
}