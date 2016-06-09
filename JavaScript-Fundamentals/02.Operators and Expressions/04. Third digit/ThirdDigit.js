/**Problem 4. Third digit
 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */

function CheckThirdDigit(number) {
    var check = ((number / 100) % 10 | 0) == 7;    // round with | 0

    return console.log(check);
}

CheckThirdDigit(9999799);