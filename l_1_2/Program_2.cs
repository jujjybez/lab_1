using System;
using System.Diagnostics;

namespace lab_1_2
{
    public class Rectangle
    {
        private double side_1;
        private double side_2;

        public Rectangle(double side_A, double side_B)
        {
            side_1 = side_A;
            side_2 = side_B;
        }

        private double CalculateArea()
        {
            return side_1 * side_2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side_1 + side_2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter rectangle side 1: ");
            double side_A = double.Parse(Console.ReadLine());           // parse - конвертация из строки в double
            Console.WriteLine("Enter rectangle side 2: ");
            double side_B = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side_A, side_B);

            Console.WriteLine($"Rectangle area: {rectangle.Area}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
