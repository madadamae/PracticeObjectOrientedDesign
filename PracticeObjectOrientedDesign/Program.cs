using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Shape
            {
                Type = ShapeType.Circle,
                Radius = 5
            };

            Shape square = new Shape
            {
                Type = ShapeType.Square,
                SideLength = 10
            };

           
            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();

            Console.WriteLine("円の面積: " + circleArea);
            Console.WriteLine("正方形の面積: " + squareArea);
        }
    }
}
