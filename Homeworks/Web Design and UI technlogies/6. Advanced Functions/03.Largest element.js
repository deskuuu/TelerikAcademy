function getLargestElement() {
    return arguments[0].reduce((x, y)=>Math.max(x, y));
}

// Test
let largest = getLargestElement([1, 44, 123, 33]);
console.log(largest);