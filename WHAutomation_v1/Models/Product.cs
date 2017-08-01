namespace WHAutomation_v1
{
    public class Product
    {
        public string Name { get; }
    }

    public class LiquidProduct : Product, IProduct<LiquidProductSize>
    {
        public LiquidProduct(string name, IBasicSize<LiquidProductSize> productSize)
        {
        }

        public IBasicSize<LiquidProductSize> ProductSize { get; }
    }

    public class PieceProduct : Product, IProduct<PieceProductSize>
    {
        public PieceProduct(string name, IBasicSize<PieceProductSize> productSize)
        {
        }

        public IBasicSize<PieceProductSize> ProductSize { get; }
    }

    public class ThreeDProduct : Product, IProduct<ThreeDProductSize>
    {
        public ThreeDProduct(string name, IBasicSize<ThreeDProductSize> productSize)
        {
        }

        public IBasicSize<ThreeDProductSize> ProductSize { get; }
    }
}