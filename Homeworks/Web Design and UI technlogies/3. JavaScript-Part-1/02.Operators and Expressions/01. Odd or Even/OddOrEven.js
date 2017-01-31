/** Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.
 */

function CheckNumber(number) {
    var isOdd = false;

    if (!(number % 2 == 0)) {
        isOdd = true;
    }

    if (isOdd) {
       return console.log('odd ' + number)
    } else {
       return console.log('even ' + number)
    }

};

CheckNumber(-2); //number to check