using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args);
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x = 0, int y = 0)
            {
                X = x;
                Y = y;
            }
        }
        public class Circle
        {
            public double Radius { get; set; }
            public Point Center { get; set; }
            public Circle(double r, Point p)
            {
                Radius = r;
                Center = p;
            }

            public double Length
            {
                get { return 2 * Math.PI * Radius; }
            }

            public double Square
            {
                get { return Math.PI * Radius * Radius; }
            }
            public override string ToString()
            {
                return string.Format($"X = {Center.X} Y = {Center.Y} L = {Length} S = {Square}");
            }


        }
        static void Main()
        {
            Circle cr = new Circle(1, new Point(1, 1));
            Console.WriteLine(cr.ToString());
            cr.Center.X = 5;
            cr.Center.Y = 8;
            cr.Radius = 5;
            Console.WriteLine(cr.ToString());
            cr.Center = new Point();
            Console.WriteLine(cr.ToString());
            Console.ReadKey(true);
        }
    }
}  