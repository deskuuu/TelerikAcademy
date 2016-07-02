/**Problem 4. Maximal increasing sequence
 Write a script that finds the maximal increasing sequence in an array.
 */
function FindMaxSequence(args) {
    var arr = args[0].split('\n'),
        lengthh = +arr[0],
        numbers = arr.slice(1),
        current = +numbers[0],
        sum = 1,
        best = 0;

    for (var i = 0; i < lengthh; i += 1) {

        if (current < +numbers[i + 1]) {
            sum++;
        }
        else {
            if (sum > best) {
                best = sum;
            }
            sum = 1;
        }
        current = numbers[i + 1];
    }

    return console.log(best);
}

