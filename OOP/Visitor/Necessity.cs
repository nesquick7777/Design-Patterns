namespace Visitor
{
    internal class Necessity : Visitable
    {
        private double price;

        public Necessity(double item)
        {
            this.price = item;
        }

        public double getPrice() { return price; }

        public double accept(Visitor visitor)
        {
            return visitor.visit(this);
        }
    }
}