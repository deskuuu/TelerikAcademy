/**Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers.
 */

function FindMax(arr) {
    var min,
        max;

    arr.sort(function (x, y) {
        return x - y
    });

    min = arr[0];
    max = arr[arr.length - 1];

    console.log('Min: ' + min + '\n' + 'Max: ' + max);
}
//Check
var arr = [1, 4, 7, 2, -6, 9];
FindMax(arr);