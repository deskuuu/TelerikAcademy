namespace _01._3D_Space
{
    using System;
    using Common;

    class TestUp
    {
        static void Main()
        {
            // Create a new point
            var pointA = new Point3D() { X = 1, Y = 2, Z = 3 };

            // Call static override ToString()
            Console.WriteLine("Base point O:");
            Console.WriteLine(Point3D.BasePoint);

            Console.WriteLine("---------");
            // Calculate distance bw point and basePoint(X=0, Y=0, Z=0)
            var distance = Distance.CalculateDistance(pointA, Point3D.BasePoint);
            Console.WriteLine("Distance between pointA {0} and pointB {1} \nis {2}", pointA, Point3D.BasePoint, distance);

            // Add some points
            Path storage = new Path();
            for (int i = 1; i < 8; i++)
            {
                storage.AddPoints(new Point3D() { X = i, Y = i + 3, Z = i * 2 });
            }

            PathStorage.SavePath(storage, "..//..//Common/sample.txt"); // saving points to file "sample.txt"
            Console.WriteLine("Stored points:");
            PathStorage.LoadPath("..//..//Common/sample.txt"); // read the points
        }
    }
}

