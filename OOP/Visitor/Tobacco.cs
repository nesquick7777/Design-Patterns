namespace Visitor
{
    internal class Tobacco : Visitable
    {

        private double price;

        public Tobacco(double item)
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