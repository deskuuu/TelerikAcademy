/**Problem 4. Sort 3 numbers
 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.
 */

function Sort(a, b, c) {
    if (a > b && a > c) {
        if (b >= c) {
            return console.log(a + ' ' + b + ' ' + c);
        }
        else{
            return console.log(a + ' ' + c + ' ' + b);
        }

    } else if (b > a && b > c) {
        if (a >= c) {
            return console.log(b + ' ' + a + ' ' + c);
        }else{
            return console.log(b + ' ' + c + ' ' + a);
        }
    }
    else {
        if (a >= b) {
            return console.log(c + ' ' + a + ' ' + b);
        }
        else {
            return console.log(c + ' ' + b + ' ' + a);
        }
    }
}

//Check
Sort(-1.1, -0.5, -0.1);
Sort(-2, 4, 3);
Sort(0, -2.5, 5);
