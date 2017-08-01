namespace WHAutomation_v1
{
    public interface IProduct<T>
    {
        string Name { get; }
        IBasicSize<T> ProductSize { get; }
    }

    //public interface IPieceProduct : IProduct
    //{
    //    IBasicSize<PieceProductSize> ProductSize { get; }
    //}

    //public interface ILiquidProduct : IProduct
    //{
    //    IBasicSize<LiquidProductSize> ProductSize { get; }
    //}

    //public interface IThreeDProduct : IProduct
    //{
    //    IBasicSize<ThreeDProductSize> ProductSize { get; }
    //}


}