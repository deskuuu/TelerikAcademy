/**Problem 5. Digit as word
 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 */
function AsWord(number) {
    var num = +number[0];
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

//Check
AsWord(7);
AsWord(-0.1);