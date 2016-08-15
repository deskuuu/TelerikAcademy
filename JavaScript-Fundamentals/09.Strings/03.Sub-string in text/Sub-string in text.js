/**  Sub-string in text
 * Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 */
function solve(str) {
    var word = str[0].toLocaleLowerCase(),
        text = str[1].toLowerCase(),
        substrings = text.split(word);

    return console.log(substrings.length - 1);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);