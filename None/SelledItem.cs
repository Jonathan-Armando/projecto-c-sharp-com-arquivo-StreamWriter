using System.Globalization;

namespace None
{
    class SelledItem
    {
        public string name { get; private set;  }
        public double price { get; private set; }
        public int quantity { get; private set; }

        public SelledItem()
        {
        }

        public SelledItem(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double TotalValue()
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return name + ", " + TotalValue().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
