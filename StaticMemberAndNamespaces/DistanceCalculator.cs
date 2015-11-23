using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class DistanceCalculator
    {
        private const int Pow = 2;

        public static double Calc3DPointDistance(Point3D pointA, Point3D pointB)
        {
            return Math.Sqrt(
                Math.Pow(pointB.Xaxis - pointA.Xaxis, Pow) +
                Math.Pow(pointB.Yaxis - pointA.Yaxis, Pow) +
                Math.Pow(pointB.Zaxis - pointA.Zaxis, Pow));
        }
    
    }
}
