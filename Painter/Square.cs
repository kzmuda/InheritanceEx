using System;
using System.Collections.Generic;
using System.Text;

namespace Painter
{
    class Square : Shape
    {
        private decimal a;
        public Square(decimal a)
        {
            this.a = a;
        }
        public override decimal Area()
        {
            return a * a;
        }
    }
}
