using System.Drawing;

namespace hw8
{
    public class Circle : IShape
    {
        public Point Center { get; }
        public int Radius { get; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }
        
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"I am a Circle, my center is {Center}, and radius is {Radius}";
        }  
    }
}
