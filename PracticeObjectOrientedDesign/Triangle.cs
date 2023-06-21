using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Triangle : ICalculateArea
    {
        double radius;
        double tole;
        public double ICalculateArea()
        {
            double anser;
            anser = (radius * tole) / 2;
            return anser;
        }
    }
}
