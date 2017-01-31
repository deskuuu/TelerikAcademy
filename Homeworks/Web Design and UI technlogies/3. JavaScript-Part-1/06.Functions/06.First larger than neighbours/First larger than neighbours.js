/** Problem 6. First larger than neighbours
 * Write a method that returns the index of the first element in
 * array that is larger than its neighbours, or -1, if there is no such element.
 * Input                Output
 6
 -26 -25 -28 31 2 27    1
 */
function Larger(args) {
    var arrayLength = args[0],
        array = args[1].split(' ').map(Number),
        i;

    for (i = 0; i < arrayLength; i += 1) {
        if (array[i] < array[i + 1]) {
            return i;
        }
    }

    return -1;
}
