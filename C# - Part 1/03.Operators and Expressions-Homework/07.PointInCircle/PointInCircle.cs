/**Write a program that reads the coordinates of a point x and y and using an expression checks 
   if given point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) 
   and the circle has radius 2. The program should then print "yes DISTANCE" if the point is inside the circle or 
  "no DISTANCE" if the point is outside the circle.

  In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.*/

using System;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float r = 2f; //radius
           
            bool isPoint = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(r, 2);
            float point = (float)Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));

            string isPointInCircle = isPoint ? "yes " : "no ";
            Console.WriteLine(isPointInCircle + string.Format("{0:F2}", point));
        }
    }
}
