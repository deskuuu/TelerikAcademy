/**Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */
function CompareCharArr(args) {
    var arr = args[0].split('\n'),
        a = String(arr[0]),
        b = String(arr[1]);

    if (a > b) {
        console.log('>');
    }
    else if (a < b) {
        console.log('<');
    }
    else if (a === b) {
        console.log('=');
    }
}
//Check
CompareCharArr(['food', 'food']);
