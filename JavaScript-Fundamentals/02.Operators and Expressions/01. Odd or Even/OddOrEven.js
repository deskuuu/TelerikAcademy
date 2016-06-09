/** Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.
 */

function CheckNumber(number){
    var isOdd = false;

    if (!(number % 2 == 0)) {
        isOdd = true;
    }

    return console.log(isOdd);
};

CheckNumber(0); //number to check