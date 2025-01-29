using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_.Classes
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public Circle(double r) 
        {
            Radius = r;
        }
        public double Area 
        {
            get { return Math.PI *Radius*Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Where radius is {Radius}, Area is {Area}");
        }
    }
}
