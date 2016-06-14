/**Problem 4. Third digit
 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */

function CheckThirdDigit(number) {
    var digit = (number / 100) % 10 | 0,
        check = digit == 7; // round with | 0

    if (check) {
        return console.log(check);
    } else {
        return console.log('false ' + digit);
    }
}

CheckThirdDigit(877);