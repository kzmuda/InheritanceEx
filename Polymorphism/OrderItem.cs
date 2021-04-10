namespace Polymorphism
{
    public class OrderItem
    {
        protected string productName;
        protected int quantity;
        protected decimal unitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            return this.quantity * this.unitPrice;
        }

        public override string ToString()
        {
            return $"Product name: {this.productName}, Price {this.unitPrice}, quantity: {this.quantity}, value: {GetValue()}";
        }
    }
}