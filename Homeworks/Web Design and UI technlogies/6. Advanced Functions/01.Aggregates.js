function printInformation() {
    let args = arguments[0];

    const funcs = {
        sum: args.reduce((x, y)=>x + y),
        min: args.reduce((x, y)=>Math.min(x, y)),
        max: args.reduce((x, y)=>Math.max(x, y)),
        product: args.reduce((x, y)=>x * y),
        join: args.reduce((x, y)=>args.join('')),
    };

    return `   Sum = ${funcs.sum}
   Min = ${funcs.min}
   Max = ${funcs.max}
   Product = ${funcs.product}
   Join = ${funcs.join}`;
}
// Test
console.log(printInformation([5, -3, 20, 7, 0.5]));
/*Sum = 29.5
 Min = -3
 Max = 20
 Sum = -1050
 Join = 5-32070.5*/