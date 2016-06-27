/**Problem 1. Exchange if greater
 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */

function Exchange(args) {
    var a = +args[0],
        b = +args[1],
        aIsGreather = a > b;

    return aIsGreather ? console.log(b + " " + a) : console.log(a + " " + b);
}

// Check
Exchange(['3', '5']);
Exchange(['5.5', '4.5']);