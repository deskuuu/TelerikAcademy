/**Problem 7. Binary search
 Write a script that finds the index of given element in a
 sorted array of integers by using the binary search algorithm
 */
function BinarySearch(args) {
    var array = args[0].split("\n").map(Number),
        n = +array[0],
        target = +array[array.length - 1],
        minIndex = 0,
        maxIndex = array.length - 1,
        currentIndex,
        currentElement;

    array.shift();
    array.pop();

    while (minIndex <= maxIndex) {
        currentIndex = ((minIndex + maxIndex) / 2) | 0;

        currentElement = +array[currentIndex];

        if (target > currentElement) {
            minIndex = currentIndex + 1;
        }
        else if (target < currentElement) {
            maxIndex = currentIndex - 1;
        }
        else {
            return currentIndex;
        }
    }

    return -1;
}
