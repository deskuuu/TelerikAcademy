/**Problem 4. Matrix of numbers
 * Write a javascript function that prints a matrix like in the examples below by a given integer N. Use two nested loops.
 Challenge: achieve the same effect without nested loops.
 3
 1 2 3
 2 3 4
 3 4 5
 */
function PrintMatrix(args) {
    var n = +args[0],
        row = '';

    for (var i = 1; i <= n; i++) {
        for (var j = i; j <= n + (i - 1); j++) {
            row += j + ' ';
        }
        console.log(row);
        row = '';
    }
}

// Check
PrintMatrix(['3']);

