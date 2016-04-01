/*Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
  and out of the rectangle R(top=1, left=-1, width=6, height=2).
 
 Print inside circle if the point is inside the circle and outside circle if it's outside. 
 Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and 
 outside rectangle otherwise. See the sample tests for a visual description.*/

using System;

namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5; //radius
            
            //K({1, 1}, 1.5)
            bool isPointInside = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(r, 2);
            string pointInCircle = isPointInside ? "inside circle" : "outside circle";
            //R(top=1, left=-1, width=6, height=2).
            bool isPointInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
            string pointInRectangle = isPointInRectangle ? "inside rectangle" : "outside rectangle";

            Console.WriteLine(pointInCircle + " " + pointInRectangle);
        }   
    }
}
