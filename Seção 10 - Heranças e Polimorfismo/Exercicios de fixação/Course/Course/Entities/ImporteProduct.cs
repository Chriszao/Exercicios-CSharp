using System.Globalization;

namespace Course.Entities
{
    class ImporteProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImporteProduct()
        {

        }

        public ImporteProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + ", R$" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (CustomsFee: R$" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
