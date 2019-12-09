using System;

namespace hw8
{
    public class VisitorGetArea : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine(circle);
            Console.WriteLine($"And my area is {circle.Radius*circle.Radius*3.14}");
        }

        public void Visit(Triangle tgl)
        {
            Console.WriteLine(tgl);
            var area = 0.5 * ((tgl.Point1.X - tgl.Point3.X) * (tgl.Point2.Y - tgl.Point3.Y)
                              - (tgl.Point2.X - tgl.Point3.X) * (tgl.Point1.Y - tgl.Point3.Y));
            Console.WriteLine($"And my area is {Math.Abs(area)}");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine(rectangle);
            Console.WriteLine($"And my area is {rectangle.Width*rectangle.Height}");
        }
    }
}
