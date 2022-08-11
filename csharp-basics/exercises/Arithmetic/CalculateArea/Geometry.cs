using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static decimal AreaOfCircle(decimal radius)
        {
            return Math.Round((decimal)Math.PI * radius * 2, 2);
        }

        public static decimal AreaOfRectangle(decimal length, decimal width)
        {
            return length * width;
        }

        public static decimal AreaOfTriangle(decimal ground, decimal h)
        {
            return ground * h * (decimal)0.5;
        }
    }
}
