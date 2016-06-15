/**Problem 3. Rectangle area
 Write an expression that calculates rectangle’s area by given width and height.
 */

/*function CalculateArea(width, height) {
 return console.log(width * height);
 }*/
//CalculateArea(2.5, 3);    // check function
function CalculateArea(args) {
    var a = +args[0],
        b = +args[1];

    var area = a * b,
        perimeter = a * 2 + b * 2;

   return console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

