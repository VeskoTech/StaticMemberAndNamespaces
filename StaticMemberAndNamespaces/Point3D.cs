using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0,0,0);

        public Point3D(double xAxis, double yAxis, double zAxis)
        {
            this.Xaxis = xAxis;
            this.Yaxis = yAxis;
            this.Zaxis = zAxis;
        }

        public double Xaxis { get; set; }
        public double Yaxis { get; set; }
        public double Zaxis { get; set; }

        public static Point3D StartPointCordinates
        {
            get { return Point3D.StartingPoint; }
        }

        public override string ToString()
        {
            return String.Format("Point{{X={0}, Y={1}, Z={2}}}",this.Xaxis,this.Yaxis,this.Zaxis);
        }
    }
}
