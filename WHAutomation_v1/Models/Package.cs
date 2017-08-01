namespace WHAutomation_v1
{
    public abstract class Package<T>
    {
        public string Manufacturer { get; }
    }

    public class PiecePackage : Package<ProductSize>, IPackage<PieceProductSize>
    {
        public PiecePackage(string manufacturer, IBasicSize<PieceProductSize> size)
        {
            
        }
        public bool FitProduct(PieceProductSize product)
        {
            throw new System.NotImplementedException();
        }
    }

    public class LiquidsPackage : Package, IPackage<LiquidProductSize>
    {
        public LiquidsPackage(string manufacturer, IBasicSize<LiquidProductSize> size)
        {

        }

        public bool FitProduct(LiquidProductSize product)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ThreeDPackage : Package, IPackage<ThreeDProductSize>
    {
        public ThreeDPackage(string manufacturer, IBasicSize<ThreeDProductSize> size)
        {

        }

        public bool FitProduct(ThreeDProductSize product)
        {
            throw new System.NotImplementedException();
        }
    }


}