/** Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

function FindTheBiggest(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        biggest;

    if (a > b && a > c) {
        biggest = a;
    } else if (b > a && b > c) {
        biggest = b;
    }
    else {
        biggest = c;
    }

    return biggest;
}

//Check
FindTheBiggest(['0', '-2.5', '5']);
