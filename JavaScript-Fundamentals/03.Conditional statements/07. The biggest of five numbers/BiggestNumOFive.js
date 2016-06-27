/**Problem 7. The biggest of five numbers
 Write a script that finds the greatest of given 5 variables.
 */

function BiggestNumOFive(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = +args[3],
        e = +args[4],
        arr = [a, b, c, d, e];

    arr.sort(function (x, y) {
        return x - y;
    });
    return arr[4];
}

//Check
var output = BiggestNumOFive(5, 2, 2, 4, 1);
console.log(output);

var output = BiggestNumOFive(-3, -0.5, -1.1, -2, -0.1, -0.1);
console.log(output);

var output = BiggestNumOFive(-2, 4, 2, 0, 4);
console.log(output);
