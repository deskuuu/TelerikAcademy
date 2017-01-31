/**Problem 8. Trapezoid area
 Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
function CalculateTrapezid(args) {
    var a = +args[0],
        b = +args[1],
        h = +args[2];

    var area = ((a + b) / 2) * h;

    return console.log(area.toFixed(7));
}