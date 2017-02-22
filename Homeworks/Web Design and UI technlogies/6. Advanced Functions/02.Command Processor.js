function processor() {
    let length = arguments[0].length,
        currentCommand = arguments[0][0],
        index = 1,
        result = '';

    const commands = {
        append: function (result, value) {
            return result + value;
        },
        removeStart: function (result, value) {
            return result.slice(value);
        },
        removeEnd: function (result, value) {
            return result.slice(0, result.length - value);
        }
    };

    while (index <= length) {
        currentCommand = currentCommand.split(' ');

        let command = currentCommand[0],
            value = currentCommand[1];

        switch (command) {
            case 'append' :
                result = commands.append(result, value);
                break;
            case 'removeStart' :
                result = commands.removeStart(result, value);
                break;
            case 'removeEnd' :
                result = commands.removeEnd(result, value);
                break;
            case 'print' :
                return result;
                break;
            default:
                throw new Error('Invalid command!');
                break;
        }

        currentCommand = arguments[0][index++];
    }
}

// Test
let output = processor(['append 123', 'append 45', 'removeStart 2', 'removeEnd 1', 'print']);  // 34
console.log(output);

let output2 = processor(['append hello', 'append again', 'removeStart 3', 'removeEnd 4', 'print']);  // loa
console.log(output2);