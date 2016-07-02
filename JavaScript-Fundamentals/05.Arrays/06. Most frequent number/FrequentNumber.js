/**Problem 6. Most frequent number
 Write a script that finds the most frequent number in an array.
 */
function MostFrq(args) {
    var input = +args[0].split('\n'),
        n = input[0],
        numbers = input.slice(1),
        current = numbers[0],
        counter,
        bestNum = 0,
        bestCounter = 0,
        result = [];

    numbers.sort();

    for (counter = 0; counter < n; counter += 1) {
        if (numbers[counter] == numbers[counter + 1]) {
            current += 1;
        }
        else {
            if (current > bestCounter) {
                bestCounter = current;
                bestNum = numbers[counter];
                current = 1;
            }
            else {
                current = 1;
            }
        }
    }

    if (current > bestCounter) {
        bestCounter = counter;
        bestNum = numbers[n];
    }

    result[0] = bestNum;
    result[1] = bestCounter;

    return console.log(bestNum + " (" + bestCounter + " times)");
}