using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    internal struct Point
    {
        double x { get; set; }
        double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point otherPoint)
        {
            double dx = otherPoint.x - this.x;
            double dy = otherPoint.y - this.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }    
}
