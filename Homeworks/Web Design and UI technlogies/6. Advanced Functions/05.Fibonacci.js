function getToNFibonacci() {
    let to = arguments[0],
        first = 0,
        second = 1,
        output = [];

    while (to > 0) {
        second = first + second;
        first = second - first;
        output.push(first);

        to--;
    }

    return output;
}

let fibs = getToNFibonacci(15);
console.log(fibs);