using System;

namespace WHAutomation_v1
{
    public class PackedProduct : IPackedProduct
    {
        public PackedProduct(IProduct product, IPackage package, DateTime packedOn, string packedBy)
        {
            Product = product;
            Package = package;
            PackedOn = packedOn;
            PackedBy = packedBy;
        }

        public IProduct Product { get; }
        public IPackage Package { get; }
        public DateTime PackedOn { get; }
        public string PackedBy { get; }

        public override string ToString()
        {
            return $"Product: {Product}, Package: {Package}, PackedOn: {PackedOn}, PackedBy: {PackedBy}";
        }
    }
}