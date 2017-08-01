using System;
using System.Data;
using Microsoft.SqlServer.Server;

namespace WHAutomations_v3
{
    public interface IProduct
    {
        string Name { get; }
        ProductCategory ProductCategory { get; }
        BasicSize SizeOfProduct { get; }
    }

    public abstract class BasicProduct
    {
        public ProductCategory ProductCategory { get; protected set; }
        public BasicSize SizeOfProduct { get; protected set; }
        public string Name { get; protected set; }

        public override string ToString()
        {
            return $"ProductCategory: {ProductCategory}, SizeOfProduct: {SizeOfProduct}, Name: {Name}";
        }
    }

    public class LiquidProduct : BasicProduct, IProduct
    {

        public LiquidProduct(ProductCategory productCategory, string name, BasicSize size)
        {
            Name = name;
            ProductCategory = productCategory;
            SizeOfProduct = size;
        }

    }

    public class PiecesProduct : BasicProduct, IProduct
    {
        public PiecesProduct(ProductCategory productCategory, string name, BasicSize size)
        {
            Name = name;
            ProductCategory = productCategory;
            SizeOfProduct = size;
        }
    }

    public class GrosseryProduct : BasicProduct, IProduct
    {
        public GrosseryProduct(ProductCategory productCategory, string name, BasicSize size)
        {
            Name = name;
            ProductCategory = productCategory;
            SizeOfProduct = size;
        }
    }

    public interface IPackedProduct
    {
        IProduct Product { get; }
        IPackage Package { get; }
        DateTime PackedOn { get; }
        string PackedBy { get; }
    }

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