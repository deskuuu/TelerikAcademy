/**Problem 5. Selection sort
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm:
 Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */
function SelectionSort(args) {

    var input = args[0].split('\n'),
        n = +input[0],
        numbers = input.slice(1),
        min = numbers[0];

    for (var j = 0; j < n; j += 1) {
        min = numbers[j];
        for (var i = j; i < n; i += 1) {

            if (+numbers[i] < min) {
                min = +numbers[i];
                numbers[i] = +numbers[j];
                numbers[j] = min;
            }
        }
    }
    console.log(numbers.join('\n'));
}

