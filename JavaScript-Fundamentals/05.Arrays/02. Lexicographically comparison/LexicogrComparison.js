/**Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */
function CompareCharArr(firstArr, secondArr) {
    var a = firstArr.length,
        b = secondArr.length,
        areEquals = false,
        counter = 0;

    if (a > b) {
        console.log('First is greather.');
    } else if (b > a) {
        console.log('Second is greather.');
    } else {

        while (counter < a) {
            if (firstArr[counter] == secondArr[counter]) {
                areEquals = true;
            }
            counter += 1;
        }
        return console.log(areEquals ? 'They are equals.' : 'They aren`t equals.');
    }
}
//Check
var a = 'Academy';
var b = 'Telerik';
CompareCharArr(a, b);
