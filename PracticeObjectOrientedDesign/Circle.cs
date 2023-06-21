using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Circle : ICalculateArea
    {
        public double ICalculateArea()
        {
            double anser;
            Shape shape = new Shape();
            anser = Math.PI * shape.Radius * shape.Radius;
            return anser;
        }
    }
}
