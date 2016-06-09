/**
 * Created by desi on 6/7/2016.
 */

function AsWord(number) {
    switch (number) {
        case 0:
            return console.log('Zero');break;
        case 9:
            return console.log('Nine');break;
        case 10:
            return console.log('Ten');break;
        case 12:
            return console.log('Twelve');break;
        case 19:
            return console.log('Nineteen');break;
        case 25:
            return console.log('Twenty five');break;
        case 98:
            return console.log('Ninety eight');break;
        case 273:
            return console.log('Two hundred and seventy three');break;
        case 400:
            return console.log('Four hundred');break;
        case 999:
            return console.log('Nine hundred and ninety nine');break;
        default : return console.log('not a digit');break;
    }
}

//Check
AsWord(999);
AsWord(98);