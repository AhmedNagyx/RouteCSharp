using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_.Classes
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set;}

        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }

        public double Area
        {
            get {return (Width * Height);}
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Where width is {Width} and height is {Height}, Area is {Area}");
        }
    }
}
