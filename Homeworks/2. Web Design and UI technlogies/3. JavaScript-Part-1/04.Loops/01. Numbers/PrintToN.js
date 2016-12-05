/** Problem 1. Numbers
 Write a script that prints all the numbers from 1 to N.
 */

function PrintToN(args) {
    var n = 1,
        number = +args[0],
        str = '';

    while (n <= number) {
        str += n + ' ';
        n += 1;
    }

    return console.log(str);
}
//Check
PrintToN(['5']);