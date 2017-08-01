namespace WHAutomation_v1
{
    public interface IPackingLineCoordinator
    {
        IPackingLine GetPackingLineBy(Product product);
    }
}