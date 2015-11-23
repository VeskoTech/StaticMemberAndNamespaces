using System;


namespace _01_Point3D
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.StartPointCordinates);

            
            Point3D fistPoint = new Point3D(3,5,2);
            Point3D secondPoint = new Point3D(4,8.4,11);
            double distance =  DistanceCalculator.Calc3DPointDistance(fistPoint, secondPoint);
            Console.WriteLine("Distance = "+distance);
        }
    }
}
