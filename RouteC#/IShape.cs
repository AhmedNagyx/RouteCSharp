using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public interface IShape
    {
        public double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
