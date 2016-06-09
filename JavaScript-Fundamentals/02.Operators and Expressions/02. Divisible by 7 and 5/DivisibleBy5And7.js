/**Problem 2. Divisible by 7 and 5
 Write a boolean expression that checks for given integer if it
 can be divided (without remainder) by 7 and 5 in the same time.
 */

function DevidedByBoth(number) {
    var isDevideble = true;

    if (!(number % 7 == 0 && number % 5 == 0)) {
        isDevideble = false;
    }

    return console.log(isDevideble);
}

DevidedByBoth(140);   //number to check