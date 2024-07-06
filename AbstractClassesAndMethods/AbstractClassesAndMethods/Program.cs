using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(double r)
        {
            Radius = r;
        }
        
        public override double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle (double L, double H)
        {
            Length = L;
            Height = H;
        }
        public override double GetArea()
        {
            return Length * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Radius");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(r);
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Please Enter Rectanle Length");
            double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Rectangle Height");
            double H = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(L, H);
            Console.WriteLine($"The area of the Rectangle is: {rectangle.GetArea()}");

            Console.ReadKey();
        }
    }
}
