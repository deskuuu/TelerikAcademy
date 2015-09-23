/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

x	y	inside
0	1	true
-2	0	true
-1	2	false
1.5	-1	true
-1.5	-1.5	false
100	-30	false
0	0	true
0.2	-0.8	true
0.9	-1.93	false
1	1.655	true
*/
using System;

class PointInACircule
    {
        static void Main(string[] args)
        {
        double x = 0.9;
        double y = -1.93;

        //Formula is (x-k)^2 + (y-k)^2 = r^2

        bool isInside = (x * x - y * y) <= 2 * 2;
        Console.WriteLine("The point {0},{1} is {2} a circle", x,y, isInside ? "inside" : "outside");
        
    }
 }

