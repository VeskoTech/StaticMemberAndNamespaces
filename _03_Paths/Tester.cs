using System;
using _01_Point3D;

namespace _03_Paths
{
    class Tester
    {
        private const string File = "PathFile.txt";
        static void Main(string[] args)
        {
            var path = new Path3D(
                new Point3D(11, 2.2, 6),
                new Point3D(4, 5, 83.2),
                new Point3D(0, 0, 0),
                new Point3D(3, 12, 13));

            
            Storage.SavePath(File, path);

            Path3D path1 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path1.Path));
        }
    }
}
