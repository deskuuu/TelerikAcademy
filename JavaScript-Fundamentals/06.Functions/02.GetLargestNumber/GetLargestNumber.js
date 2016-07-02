//Write a method GetMax() with two parameters that returns the larger
//of two integers. Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

function GetLargestNumber(args) {
    var input = args[0].split(' ').map(Number),
        a = input[0],
        b = input[1],
        c = input[2];

    // max = Math.max(a, b, c);
    if (GetMax(a, b) > c) {
        return GetMax(a, b);
    } else {
        return c;
    }

    function GetMax(first, second) {
        return first > second ? first : second;
    }

    return console.log(max);
}
//test
GetLargestNumber(['8', '3 ', '6']);
GetLargestNumber(['1', '1 ', '3']);