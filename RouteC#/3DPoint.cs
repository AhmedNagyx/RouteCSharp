using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class _3DPoint : IComparable<_3DPoint>, ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public _3DPoint() : this(0,0,0)
        { 
        }

        public _3DPoint(int x ,int y) : this( x, y,0)
        {
            
        }
        public _3DPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
        public static _3DPoint ReadPoint(string point)
        {
            int x,y,z;
            Console.WriteLine($"Enter coordinates for {point}");
            bool checkX = int.TryParse(Console.ReadLine(),out x);
            bool checkY = int.TryParse(Console.ReadLine(), out y);
            bool checkZ = int.TryParse(Console.ReadLine(), out z);
          
            return new _3DPoint(x,y,z);

        }

        public int CompareTo(_3DPoint other)
        {
            if (other == null) 
                return 1;
            int compareX = x.CompareTo(other.x);
            if (compareX != 0)
                return compareX;
            int compareY = y.CompareTo(other.y);
            if (compareY != 0)
                return compareY;
            return z.CompareTo(other.z);
        }

        public object Clone()
        {
            return new _3DPoint(x,y,z);
        }

      
    }
}
