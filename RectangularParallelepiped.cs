using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    public class RectangularParallelepiped:SpatialFigure
    {
        private double length;
        private double width;
        private double height;

        
        public RectangularParallelepiped(double a, double b, double c)
        {
            length = a;
            width = b;
            height = c;
        }

        
        public override double GetSurfaceArea()
        {
            return 2 * (length * width + width * height + height * length);
        }

        
        public override double GetVolume()
        {
            return length * width * height;
        }
    }
}
