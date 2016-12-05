/**Problem 2. MMSA
 Implement a javascript function that accepts an array of floating-point numbers as strings and returns
 the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 */

function solve(params) {
    var min = +params[0],
        max = +params[0],
        sum = 0,
        avarage = 0,
        capacity = params.length;

    for (var i = 0; i < capacity; i++) {
        var element = +params[i];
        if (element > max) {
            max = element;
        }

        if (element < min) {
            min = element;
        }

        sum += element;
    }
    avarage = sum / capacity;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avarage.toFixed(2));
}

//Check
MMSA(['1', '4', '7', '2', '-6', '9']);