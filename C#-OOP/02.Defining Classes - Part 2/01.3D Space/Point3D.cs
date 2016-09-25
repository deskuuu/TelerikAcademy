using System;

namespace _01._3D_Space
{
    public struct Point3D
    {
        // Create a structure Point3D to hold a 3D-coordinate {X, Y, Z } in the Euclidian 3D space.
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        // Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        private static readonly Point3D basePoint = new Point3D { X = 0, Y = 0, Z = 0 };

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Add a static property to return the point O.
        public static Point3D BasePoint
        {
            get
            {
                return basePoint;
            }
        }

        // Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            return $"({X} {Y} {Z})";
        }
    }
}
