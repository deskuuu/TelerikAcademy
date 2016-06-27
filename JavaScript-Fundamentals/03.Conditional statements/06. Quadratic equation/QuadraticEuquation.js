/** Problem 6. Quadratic equation
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 */

function CalculateQuadraticRoots(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = b * b - 4 * a * c,
        x1,
        x2;

    if (d > 0) {
        x2 = (-b + Math.sqrt(d)) / (2 * a);
        x1 = (-b - Math.sqrt(d)) / (2 * a);
        return console.log('x1=' + x1.toFixed(2) + ';' + ' x2=' + x2.toFixed(2));
    } else if (d === 0) {
        x1 = -b / (2* a);
        return console.log('x1=x2=' + x1.toFixed(2));
    }
    else {
        return console.log('no real roots');
    }
}
//Check
CalculateQuadraticRoots(2, 5, -3);       //x1=-3; x2=0.5
CalculateQuadraticRoots(-1, 3, 0);       //x1=3; x2=0
CalculateQuadraticRoots(5, 2, 8);       //no real roots
