namespace WHAutomations_v3
{
    public interface IPackage
    {
        BasicSize SizeOfPack { get; }
        bool Fits(IProduct p);
    }

    public abstract class BasicPack : IPackage
    {
        public BasicSize SizeOfPack { get; protected set; }

        public abstract bool Fits(IProduct p);

        public override string ToString()
        {
            return $"SizeOfPack: {SizeOfPack}";
        }
    }


    public class LiquidsPack : BasicPack
    {
        public LiquidsPack(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(IProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }


    public class GrosseryPack : BasicPack
    {
        public GrosseryPack(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(IProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }


    public class PiecesPack : BasicPack
    {
        public PiecesPack(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(IProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}