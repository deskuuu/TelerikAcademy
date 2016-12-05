/**  Correct brackets
 * Write a JavaScript function to check if in a given expression the brackets are put correctly.
 */
function correctBrackets(str) {
    var isCorrect = false,
        op = 0,
        cl = 0,
        str=str[0].trim();

    for (var i = 0; i < str.length; i += 1) {
        if (str[i] == '(') {
            op += 1;
        } else if (str[i] == ')') {
            cl += 1;
        }
    }

    if (op == cl) {
        isCorrect = true;
    }

    console.log(isCorrect ? 'Correct' : 'Incorrect');
}

correctBrackets([')(a+b))']);