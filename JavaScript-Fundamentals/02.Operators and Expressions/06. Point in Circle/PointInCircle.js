/**Problem 6. Point in Circle
 Write an expression that
 checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
 */

function CheckInCircle(x, y) {
//The formula for circle is (x-k)^2 + (y-k)^2 = r^2

    var IsInCircle = (x * x) + (y * y) <= (5 * 5);

    return console.log(IsInCircle);
}

CheckInCircle(2, 2.655);