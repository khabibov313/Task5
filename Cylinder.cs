using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
     public class Cylinder:SpatialFigure
    {
        private double radius;
        private double length;

        
        public Cylinder(double r, double l)
        {
            radius = r;
            length = l;
        }

        
        public override double GetSurfaceArea()
        {
            return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * length;
        }

       
        public override double GetVolume()
        {
            return Math.PI * radius * radius * length;
        }
    }
}
