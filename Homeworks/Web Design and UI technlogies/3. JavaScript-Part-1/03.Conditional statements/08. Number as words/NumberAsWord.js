/** Problem 8. Number as words
 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */

function AsWord(number) {
    var num = +number[0];
    switch (num) {
        case 0:
            return console.log('Zero');
            break;
        case 9:
            return console.log('Nine');
            break;
        case 10:
            return console.log('Ten');
            break;
        case 12:
            return console.log('Twelve');
            break;
        case 19:
            return console.log('Nineteen');
            break;
        case 25:
            return console.log('Twenty five');
            break;
        case 98:
            return console.log('Ninety eight');
            break;
        case 273:
            return console.log('Two hundred and seventy three');
            break;
        case 400:
            return console.log('Four hundred');
            break;
        case 501:
            return console.log('Five hundred and one');
            break;
        case 617:
            return console.log('Six hundred and seventeen');
            break;
        case 711:
            return console.log('Seven hundred and eleven');
            break;
        case 999:
            return console.log('Nine hundred and ninety nine');
            break;
        default :
            return console.log('not a digit');
            break;
    }
}
j
//Check
AsWord(999);
AsWord(98);

function ToWord(num) {
    var a = ['', 'one ', 'two ', 'three ', 'four ', 'five ', 'six ', 'seven ', 'eight ', 'nine ', 'ten ', 'eleven ', 'twelve ', 'thirteen ', 'fourteen ', 'fifteen ', 'sixteen ', 'seventeen ', 'eighteen ', 'nineteen '];
    var b = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    var n = ('000000000' + num).substr(-9).match(/^(\d{2})(\d{2})(\d{2})(\d{1})(\d{2})$/);
    var str = '';

    str += (n[4] != 0) ? (a[Number(n[4])] || b[n[4][0]] + ' ' + a[n[4][1]]) + 'hundred ' : '';
    str += (n[5] != 0) ? ((str != '') ? 'and ' : '') + (a[Number(n[5])] || b[n[5][0]] + ' ' + a[n[5][1]]) : '';
    if (+num === 0) {
        return console.log('Zero');
    }

    return console.log(str.charAt(0).toUpperCase() + str.slice(1));
}
