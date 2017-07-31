namespace WHAutomation_v1
{
    public interface IPackingLine
    {
        IPackedProduct Pack(IProduct product);
    }
}