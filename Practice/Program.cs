using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 10);
           
            Console.WriteLine($"Width is {rectangle1.Width}");
            Console.WriteLine($"Height is {rectangle1.Height}");
            Console.WriteLine($"Area is {rectangle1.CalculateArea()}");
            Console.WriteLine($"Circumference is {rectangle1.CalculateCircumference()}");
           
            Console.ReadLine();
        }

    }

    class Rectangle
    {
        // fields
        public int Width;
        public int Height;

        // constructor
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // methods
        public int CalculateCircumference()
        {
            return 2 * Width + 2 * Height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}





