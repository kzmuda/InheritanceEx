using System;
using System.Collections.Generic;
using System.Text;

namespace Painter
{
    class Circle : Shape
    {
        private decimal r;
        public Circle(decimal r)
        {
            this.r = r;
        }
        public override decimal Area()
        {
            return (decimal)Math.PI * r * r;
        }
    }
}
