using System;

namespace WHAutomations_v2
{
    public abstract class BasicProduct
    {
        public BasicSize SizeOfProduct { get; protected set; }
    }

    public class ProductA : BasicProduct
    {
        public ProductA(BasicSize size)
        {
            SizeOfProduct = size;
        }
    }

    public class ProductC : BasicProduct
    {
        public ProductC(BasicSize size)
        {
            SizeOfProduct = size;
        }
    }

    public class ProductB : BasicProduct
    {
        public ProductB(BasicSize size)
        {
            SizeOfProduct = size;
        }
    }
}