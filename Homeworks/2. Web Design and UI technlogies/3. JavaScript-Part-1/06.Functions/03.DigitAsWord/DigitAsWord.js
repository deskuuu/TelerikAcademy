/**Problem 3. English digit
 * Write a method that returns the last digit
 * of given integer as an English word. Write a program that reads a number and prints the result of the method.
 */

function AsWord(args) {
    var n = +args[0],
        temp = n.toString(),
        lastNum = parseInt(temp[temp.length - 1]);

    return ToWord(lastNum);

    function ToWord(num) {
        switch (num) {
            case 0:
                return console.log('zero');
                break;
            case 1:
                return console.log('one');
                break;
            case 2:
                return console.log('two');
                break;
            case 3:
                return console.log('three');
                break;
            case 4:
                return console.log('four');
                break;
            case 5:
                return console.log('five');
                break;
            case 6:
                return console.log('six');
                break;
            case 7:
                return console.log('seven');
                break;
            case 8:
                return console.log('eight');
                break;
            case 9:
                return console.log('nine');
                break;
            default :
                return console.log('not a digit');
                break;
        }

    }
}
// Test
AsWord(['43']);