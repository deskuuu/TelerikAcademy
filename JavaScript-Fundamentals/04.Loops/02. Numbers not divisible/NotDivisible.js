/**Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N,
 that are not divisible by 3 and 7 at the same time
 */
function PrintToN(number) {
    var n = 1;

    while (n <= number) {
        if (n % 3 == 0 && n % 7 == 0) {
            console.log(n);
        }
        n += 1;
    }
}
//Check
PrintToN(100);