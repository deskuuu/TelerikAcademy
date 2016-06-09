/**Problem 1. Increase array members
 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */
function IncreaseArray(number) {
    var index = 0,
        arr = [];

    while (index <= number) {
        arr.push(index * 5);
        index += 1;
    }

    return arr.toString();
}
//Check
console.log(IncreaseArray(20));