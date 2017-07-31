namespace WHAutomation_v1
{
    public interface IPackingLineCoordinator
    {
        IPackingLine GetPackingLineBy(IProduct product);
    }
}