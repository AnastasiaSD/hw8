using System.Drawing;

namespace hw8
{
    public class Triangle : IShape
    {
                
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }
        
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"I am a triangle, my tops is {Point1}, {Point2}, {Point3}";
        }  
    }
}
