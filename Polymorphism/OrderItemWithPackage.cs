namespace Polymorphism
{
    public class OrderItemWithPackage: OrderItem
    {
        private string namePackage;
        private decimal price;

        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice, string namePackage, decimal price) : base(productName, quantity, unitPrice)
        {
            this.namePackage = namePackage;
            this.price = price;
        }

        public override decimal GetValue()
        {
            return (base.GetValue() + this.quantity * this.price);
        }

        public override string ToString()
        {
            return base.ToString() + $"package: {this.namePackage}, package price: {this.price}";
        }
    }
}