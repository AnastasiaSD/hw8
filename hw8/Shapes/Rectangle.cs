using System.Drawing;

namespace hw8
{
    public class Rectangle : IShape
    {
        public Point TopLeftPoint { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(Point topLeftPoint, int width, int height)
        {
            TopLeftPoint = topLeftPoint;
            Width = width;
            Height = height;
        }
        
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }

        public override string ToString()
        {
            return $"I am a Rectangle, my top left point is {TopLeftPoint}, " +
                   $"width : {Width}, height : {Height}";
        }  
    }
}