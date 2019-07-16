namespace Visitor
{
    public class Perfume : ProductBase, IVisitable
    {
        public Perfume(double price) : base(price)
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