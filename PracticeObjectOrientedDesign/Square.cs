using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Square : ICalculateArea
    {
        public double ICalculateArea()
        {
            double anser;
            Shape shape = new Shape();
            anser = shape.SideLength * shape.SideLength;
            return anser;
        }
    }
}
