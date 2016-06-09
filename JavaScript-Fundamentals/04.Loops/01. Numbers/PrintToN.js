/** Problem 1. Numbers
 Write a script that prints all the numbers from 1 to N.
 */

function PrintToN(number) {
    var n = 1;

    while (n <= number) {
        console.log(n);
        n += 1;
    }
}
//Check
PrintToN(10);