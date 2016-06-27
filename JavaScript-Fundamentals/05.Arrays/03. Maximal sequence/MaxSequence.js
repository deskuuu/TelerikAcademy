/**Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

function FindMaxSequence(arr) {
    //Todo: read digits from arr
    while (counter < n) {
        if (arr[counter] == +arr[counter + 1]) {
            counter += 1;
        }
    }
     return console.log(counter);
}
//Check
FindMaxSequence(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);
