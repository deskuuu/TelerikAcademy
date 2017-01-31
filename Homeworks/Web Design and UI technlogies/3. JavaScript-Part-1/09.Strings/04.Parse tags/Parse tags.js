/** Parse tags
 *You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <orgcase>text</orgcase> does not change casing
 */
function solve(args) {
    var text = args[0];

    text = text.replace();
    console.log(text);
}
solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. ' +
'We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']);
