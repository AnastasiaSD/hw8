namespace hw8
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Triangle triangle);
        void Visit(Rectangle rectangle);
    }
}
