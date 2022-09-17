using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Area
{
    static class Circle
    {
        static double area;
        public static double getArea(int r)
        {
            area = Math.PI * (r ^ 2);
            return area;
        }
        
    }
}
