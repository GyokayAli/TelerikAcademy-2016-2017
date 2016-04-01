/*Write an expression that calculates rectangle’s perimeter and 
  area by given width and height. The width and height should be read from the console.

  The input will consist of 2 lines:
   On the first line, you will receive a floating-point number that will represent the width of the rectangle.
   On the second line, you will receive another floating-point number that will represent the height of the rectangle.*/
using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            decimal width, 
                  height, 
                  perimeter, 
                  area;

            width = decimal.Parse(Console.ReadLine());
            height = decimal.Parse(Console.ReadLine());

            perimeter = 2 * (width + height); //formula: perimeter of rectangle
            area = width * height; //formula: area of rectangle

            Console.WriteLine(string.Format("{0:F2} {1:F2}", area, perimeter));
        }
    }
}
