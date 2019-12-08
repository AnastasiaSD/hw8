using System;

namespace hw8
{
    public class VisitorDraw : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine(circle);
            Console.WriteLine("  **  ");
            Console.WriteLine(" *  * ");
            Console.WriteLine("*    *");
            Console.WriteLine(" *  * ");
            Console.WriteLine("  ** ");
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine(triangle);
            Console.WriteLine("*    ");
            Console.WriteLine("| \\  ");
            Console.WriteLine("|   >");
            Console.WriteLine("| /  ");
            Console.WriteLine("*    ");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine(rectangle);
            Console.WriteLine(".__________.");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine(".__________.");
        }
    }
}