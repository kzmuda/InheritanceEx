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
    }
}
