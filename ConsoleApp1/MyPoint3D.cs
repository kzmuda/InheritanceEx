using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyPoint3D: MyPoint
    {
        public int z;

        public MyPoint3D(int x, int y, int z): base(x, y)
        {
            this.z = z;
        }


        public override double GetDistanceFromPoint(MyPoint point)
        {
            if (point is MyPoint3D point3d)
            {
                return Math.Sqrt(Math.Pow(this.x - point3d.x, 2) + Math.Pow(this.y - point3d.y, 2) +
                                 Math.Pow(this.z - point3d.z, 2));
            }

            return 0;
        }
    }
}
