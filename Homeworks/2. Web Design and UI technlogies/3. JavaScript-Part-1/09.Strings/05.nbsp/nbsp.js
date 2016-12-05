/**  nbsp
 * Write a function that replaces non breaking white-spaces in a text with &nbsp.
 */
function solve(args) {
    var text = args[0];

    String.prototype.replaceAll = function(search, replacement) {
        var target = this;
        return target.split(search).join(replacement);
    };

    text = text.replaceAll(' ', '&nbsp;');
    return console.log(text);
}
solve(['hello world']);
solve([ 'This text contains 4 spaces!!' ]);