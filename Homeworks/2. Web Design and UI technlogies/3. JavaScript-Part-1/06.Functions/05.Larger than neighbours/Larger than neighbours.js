/**  Problem 5.Larger than neighbours
 * Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 * Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
 * Input               Output
 6                    2
 -26 -25 -28 31 2 27
 */
function largerThanNeighbours(args) {
    var arrayLength =args[0],
        array = args[1].split(' ').map(Number);

    return neighboursChecker(array, arrayLength);

    function neighboursChecker(sequence, arrLength) {
        var counter = 0,
            i;
        for (i = 1; i < arrLength - 1; i++) {
            if (sequence[i - 1] < sequence[i] && sequence[i + 1] < sequence[i]) {
                counter += 1;
            }
        }

        return counter;
    }
}
// Test
var res = largerThanNeighbours(['6', '-26 -25 -28 31 2 27']);
console.log(res);