using System;
using System.Drawing;

namespace hw8
{
    public class VisitorGetCenter : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine(circle);
            Console.WriteLine($"And my center is {circle.Center}");
        }

        public void VisitTriangle(Triangle tgl)
        {
            var centerX = (tgl.Point1.X + tgl.Point2.X + tgl.Point3.X) / 3;
            var centerY = (tgl.Point1.Y + tgl.Point2.Y + tgl.Point3.Y) / 3;
            Console.WriteLine(tgl);
            Console.WriteLine($"And my center is ({centerX},{centerY})");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            var pointDiag = new Point(rectangle.TopLeftPoint.X + rectangle.Width,
                rectangle.TopLeftPoint.Y - rectangle.Height);
            var centerX = (rectangle.TopLeftPoint.X + pointDiag.X)/2;
            var centerY = (rectangle.TopLeftPoint.Y + pointDiag.Y)/2;
            Console.WriteLine(rectangle);
            Console.WriteLine($"And my center is ({centerX},{centerY})");
        }
    }
}