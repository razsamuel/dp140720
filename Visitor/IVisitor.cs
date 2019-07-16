namespace Visitor
{
    public interface IVisitor
    {
        double Visit(Liquor liquor);

        double Visit(Tabacco tabacco);

        double Visit(Chocolate chocolate);

        double Visit(Perfume perfume);

        double Visit(ShopRent shopRent);
    }
}