namespace hw8
{
    public interface IVisitor
    {
        void VisitCircle(Circle circle);
        void VisitTriangle(Triangle triangle);
        void VisitRectangle(Rectangle rectangle);
    }
}