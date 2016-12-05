/**  Extract text from HTML
 *Write a function that extracts the content of a html page
 * given as text. The function should return anything that is in a tag, without the tags.
 */
function solve(args) {
    var text = args,
        matched = /<.*?>/ig,
        i,
        output=[];

    for (i = 0; i < text.length; i += 1) {
        output.push(text[i].trim().replace(matched, ''));
    }

    return console.log(output.join(''));
}
solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);