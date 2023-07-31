namespace Task5_2
{
    public class Program
    {
       public static void Main(string[] args)
        {
            public static void Main()
            {
                
                SpatialFigure cone = new Cone(3.0, 5.0);
                Console.WriteLine("Cone Surface Area: " + cone.GetSurfaceArea());
                Console.WriteLine("Cone Volume: " + cone.GetVolume());

                SpatialFigure cylinder = new Cylinder(2.0, 4.0);
                Console.WriteLine("Cylinder Surface Area: " + cylinder.GetSurfaceArea());
                Console.WriteLine("Cylinder Volume: " + cylinder.GetVolume());

                SpatialFigure parallelepiped = new RectangularParallelepiped(3.0, 4.0, 5.0);
                Console.WriteLine("Rectangular Parallelepiped Surface Area: " + parallelepiped.GetSurfaceArea());
                Console.WriteLine("Rectangular Parallelepiped Volume: " + parallelepiped.GetVolume());
            }
        }
    }
}