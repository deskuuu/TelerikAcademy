/** Problem 7. Sorting array
 * Write a method that returns the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.
 * Input        Output
 6
 3 4 1 5 2 6    1 2 3 4 5 6
 */
function Order(args) {
    var arrayLength = args[0],
        array = args[1].split(' ').map(Number);

  // array.sort();
    return array;
}