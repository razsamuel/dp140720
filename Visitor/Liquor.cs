namespace Visitor
{
    public class Liquor : ProductBase, IVisitable
    {
        public Liquor(double price) : base(price)
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Liquor price : {Price}";
        }
    }
}