/** Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

function FindTheBiggest(a, b, c) {
    var biggest;

    if (a > b && a > c) {
        biggest = a;
    } else if (a > a && b > c) {
        biggest = b;
    }
    else {
        biggest = c;
    }

    return biggest;
}

//Check
var result = FindTheBiggest(0, -2.5, 5);
console.log(result);