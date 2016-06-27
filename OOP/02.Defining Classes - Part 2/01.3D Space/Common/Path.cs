namespace _01._3D_Space.Common
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Path 
    {
        // Create a class Path to hold a sequence of points in the 3D space.
        private List<Point3D> points;

        public Path()
        {
            points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }

        internal int Count()
        {
            return points.Count;
        }

        public void AddPoints(Point3D point)
        {
            points.Add(point);
        }

        public Point3D this[int index]
        {
            get
            {
                return points[index];
            }
            set
            {
                points[index] = value;
            }
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
