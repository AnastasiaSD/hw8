using System.Drawing;

namespace hw8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IShape[] shapes =
            {
                new Circle(new Point(5, 5), 10),
                new Rectangle(new Point(5, 6), 5, 3), 
                new Triangle(new Point(1,3), new Point(2,-5), new Point(-8,4)), 
            };

            IVisitor[] visitors =
            {
                new VisitorDraw(),
                new VisitorGetArea(),
                new VisitorGetCenter(),
            };
            
            foreach (var shape in shapes)
                foreach (var visitor in visitors)
                    shape.AcceptVisitor(visitor);
        }
    }
}