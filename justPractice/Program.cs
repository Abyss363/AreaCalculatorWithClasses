// See https://aka.ms/new-console-template for more information
using System;

namespace AreaWithClasses
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square
    {
        public virtual int Side { get; set; }
    }
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r .Height * r.Width;
        }

        public static int CalculateArea(Square n)
        {
            return n.Side * n.Side;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            
            Rectangle rec1 = new Rectangle();
            Console.WriteLine("Please input value for height of the rectangle: ");
            rec1.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value for width of the rectangle: ");
            rec1.Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The area of the Rectangle is {AreaCalculator.CalculateArea(rec1)}");

            Console.WriteLine("Please input value for length of the side of the square: ");
            Square sqr1 = new Square();
            sqr1.Side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The area of the Square is: {AreaCalculator.CalculateArea(sqr1)}");
        }
    }
    
}