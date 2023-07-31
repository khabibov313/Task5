using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    public class Cone :SpatialFigure
    {
        private double radius;
        private double height;

        
        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }

        
        public override double GetSurfaceArea()
        {
            return Math.PI * radius * radius;
        }

        
        public override double GetVolume()
        {
            return GetSurfaceArea() * height / 3;
        }
    }
}
