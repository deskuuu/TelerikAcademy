/**Problem 2. Multiplication Sign
 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */

function CheckSign(a, b, c) {
    if (a == 0 || b == 0 || c == 0) {
        return 0;
    }
    else if((a > 0 && b > 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0)){
         return '+';
    }
    else{
        return '-';
    }
}

//Check
var check = CheckSign(-2, -2, 1);
console.log(check);
