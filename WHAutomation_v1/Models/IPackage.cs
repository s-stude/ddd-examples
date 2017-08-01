namespace WHAutomation_v1
{
    public interface IPackage<T>
    {
        string Manufacturer { get; }
        bool FitProduct(T product);
    }
}