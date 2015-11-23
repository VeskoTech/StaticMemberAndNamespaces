using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    class Storage
    {
        public static Path3D LoadPath(string source)
        {
            List<Point3D> points = new List<Point3D>();
            
            using (StreamReader reader = new StreamReader(source))
            {
                while (true)
                {
                    String line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    double[] coordinates = line.Split(' ').Select(double.Parse).ToArray();
                    double x = coordinates[0];
                    double y = coordinates[1];
                    double z = coordinates[2];
                    points.Add(new Point3D(x, y, z));
                }
            }
           
            Path3D path = new Path3D(points.ToArray());
            return path;
        }

        public static void SavePath(string destination, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(destination))
            {
                foreach (Point3D point in path.PointInPath)
                {
                    writer.WriteLine("{0} {1} {2}", point.Xaxis, point.Yaxis, point.Zaxis);
                }
            }
        }
    
    }
}
