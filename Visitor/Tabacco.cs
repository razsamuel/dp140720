namespace Visitor
{
    public class Tabacco : ProductBase, IVisitable
    {
        public Tabacco(double price) : base(price)
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Tabacco price : {Price}";
        }
    }
}