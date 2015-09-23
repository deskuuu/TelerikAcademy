/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x	y	inside K & outside of R
1	2	yes
2.5	2	no
0	1	no
2.5	1	no
2	0	no
4	0	no
2.5	1.5	no
2	1.5	yes
1	2.5	yes
-100	-100	no
*/
using System;

    class PntInsACirculeOutRect
   {
        static void Main(string[] args)
        {
        double x = 2.5;
        double y = 1.5;

        //Formula  for circle is (x-k)^2 + (y-k)^2 = r^2
        bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;

        bool outsideRectangle = (x <= -1 || x >= 5) || (y <= -1 || y >= 1);
        Console.WriteLine("The {0},{1} is {2} the circle and {3} the rectangle.", x,y, inCircle ? "inside" : "outside" , outsideRectangle ? "inside" : "outside");
       }
  }

