function process() {
    let input = arguments[0],
        length = input.length,
        currentCommand,
        index = 0,
        output = [];

    while (index < length) {
        currentCommand = input[index].split(' ');

        let command = currentCommand[0],
            value = currentCommand[1];

        switch (command) {
            case 'add':
                output.push(value);
                break;
            case 'remove':
                output = output.reduce((x)=>x != value);
                break;
            case 'print':
                console.log(output.join(','));
                break;
            default :
                throw new Error('Invalid command!');
                break;
        }

        index++;
    }
}

process(['add hello', 'add again', 'remove hello', 'add again', 'print']); // again,again