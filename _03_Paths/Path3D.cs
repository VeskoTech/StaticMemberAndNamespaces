using System.Collections.Generic;
using _01_Point3D;

namespace _03_Paths
{
    class Path3D
    {
        public Path3D(params Point3D[] points)
        {
            this.Path = new List<Point3D>();
            this.AddPoints(points);
        }

        public List<Point3D> Path { get; set; }

        private void AddPoints(params Point3D[] points)
        {
            foreach (var point3D in points)
            {
                this.Path.Add(point3D);
            }
        }
        
        public IEnumerable<Point3D> PointInPath
        {
            get
            {
                return this.Path;
            }
        }
    }
}
