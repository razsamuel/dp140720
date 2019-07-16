namespace Visitor
{
    public class Chocolate : ProductBase, IVisitable
    {
        public Chocolate(double price) : base(price)
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Chocolate price : {Price}";
        }
    }
}