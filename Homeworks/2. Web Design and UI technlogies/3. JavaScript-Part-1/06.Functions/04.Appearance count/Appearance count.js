/**  Problem 4. Appearance count
 * Write a method that counts how many times given number appears in a given array.
 */
function solve(input) {
    var nums = input[0],
        numbers = input[1].split(' ').map(Number),
        x = +input[2],
        position = 0,
        appCount = 0;

    position = numbers.indexOf(x);

    for (var i = 0; i < nums; i += 1) {

        if (position >= 0) {
            appCount += 1;
        }
        else {
            return appCount;
        }
        position = numbers.indexOf(x, position + 1);
    }
}
// Test
console.log(solve(['8', '28 6 21 6 -7856 73 73 -56', '73']));
console.log(solve(['8', '73 6 21 6 -7856 73 73 -56', '73']));