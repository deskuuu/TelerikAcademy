namespace _01._3D_Space.Common
{
   public static class Distance
    {
        // Write a static class with a static method to calculate the distance between two points in the 3D space.
        public static double CalculateDistance(Point3D x,Point3D y)
        {
            double distance = 0;
            // The formula is: d=(x2−x1)^2+(y2−y1)^2+(z2−z1)^2

            distance = System.Math.Sqrt((y.X - x.X) * (y.X - x.X) + (y.Y - x.Y) * (y.Y - x.Y) + (y.Z - x.Z) * (y.Z - x.Z));

            return distance;
        }
    }
}
