namespace WHAutomations_v2
{
    public abstract class BasicPack
    {
        public BasicSize SizeOfPack { get; protected set; }

        public abstract bool Fits(BasicProduct p);
    }


    public class PackA : BasicPack
    {
        public PackA(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(BasicProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }
    }


    public class PackB : BasicPack
    {
        public PackB(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(BasicProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }
    }


    public class PackC : BasicPack
    {
        public PackC(BasicSize size)
        {
            SizeOfPack = size;
        }
        public override bool Fits(BasicProduct p)
        {
            return SizeOfPack.Equals(p.SizeOfProduct);
        }
    }
}