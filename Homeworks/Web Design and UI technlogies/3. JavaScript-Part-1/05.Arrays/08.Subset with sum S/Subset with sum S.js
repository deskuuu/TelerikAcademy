/** Problem 8. Subset with sum S
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S.
 * input array                  S        result
 2, 1, 2, 4, 3, 5, 2, 6      14    yes
 */
function Subset(args) {
    var numbers = +args[0].split(','),
        s = numbers[args.length],
        i,
        result;

    for (i = 0; i < args.length; i += 1) {
        result = numbers[i];
        if (result == s) {
            return 'yes';
        }
        result += numbers[i];
    }
}
// Test
Subset(['2', '1', '2', '4', '3', '5', '2','6','14']);