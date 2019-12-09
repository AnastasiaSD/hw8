using System;

namespace hw8
{
    public class VisitorDraw : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine(circle);
            Console.WriteLine("  **  ");
            Console.WriteLine(" *  * ");
            Console.WriteLine("*    *");
            Console.WriteLine(" *  * ");
            Console.WriteLine("  ** ");
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine(triangle);
            Console.WriteLine("*    ");
            Console.WriteLine("| \\  ");
            Console.WriteLine("|   >");
            Console.WriteLine("| /  ");
            Console.WriteLine("*    ");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine(rectangle);
            Console.WriteLine(".__________.");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine(".__________.");
        }
    }
}
