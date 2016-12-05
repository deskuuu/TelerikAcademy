/**Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */
function FindMaxSequence(args) {
    var arr = args[0].split('\n'),
        lengthh = +arr[0],
        numbers = arr.slice(1),
        current = +numbers[0],
        sum = 1,
        max = 0;

    for (i = 0; i < lengthh; i += 1) {
        if (current == numbers[i + 1]) {
            sum += 1;
        }
        else {
            if (sum > max) {
                max = sum;
            }
            sum = 1;
        }

        current = numbers[i + 1];
    }

    return console.log(max);
}