namespace Visitor
{
    internal  class Liquor : Visitable
    {
        private double price;

        public Liquor(double item)
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