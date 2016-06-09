/**Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

function FindMaxSequence(arr) {
    var n = arr.length,
        counter = 0;

    while (counter < n) {
        if (arr[counter] == arr[counter + 1]) {
            console.log(arr[counter]);
        }

        counter+=1;
    }

}
//Check
FindMaxSequence(2, 1, 1, 2, 3, 3, 2, 2, 2, 1);
