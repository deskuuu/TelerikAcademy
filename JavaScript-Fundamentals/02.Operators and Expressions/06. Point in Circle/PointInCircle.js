/**Problem 6. Point in Circle
 Write an expression that
 checks if given point P(x, y) is within a circle K({0,0}, 2). //{0,0} is the centre and 2 is the radius
 */

/*function CheckInCircle(x, y, radius) {
 //The formula for circle is (px - cx) * (px - cx) + (py - cy) * (py - cy) <= r * r

 var point = (x * x) + (y * y),
 IsInCircle = point <= (radius * radius),
 distance = Math.sqrt(point);

 if (IsInCircle) {
 return console.log('yes ' + distance.toFixed(2));
 } else if (point == 0) {
 return console.log('0');
 }
 else {
 return console.log('no ' + distance.toFixed(2));
 }
 }*/
//CheckInCircle(1, 1.655, 2);

function CheckInCircle(args) {
    //The formula for circle is (px - cx) * (px - cx) + (py - cy) * (py - cy) <= r * r
    var x = +args[0],
        y = +args[1];
    var point = (x * x) + (y * y),
        IsInCircle = point <= (2 * 2),
        distance = Math.sqrt(point);

    if (IsInCircle) {
        console.log('yes ' + distance.toFixed(2));
    } else if (point == 0) {
        return console.log('0');
    }
    else {
       return console.log('no ' + distance.toFixed(2));
    }
}

