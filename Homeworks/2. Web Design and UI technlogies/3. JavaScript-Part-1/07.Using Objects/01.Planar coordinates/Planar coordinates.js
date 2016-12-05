/**  Planar coordinates
 Write functions for working with shapes in standard Planar coordinate system.
 */
function solve(args) {
    var a = args.slice(0, 4),
        b = args.slice(4, 8),
        c = args.splice(8),
        distances = [];

    // calculate lengths
    function CalcDistance(numbers) {
        //Distance =(x2?x1)2+(y2?y1)2
        var distance,
            x = +Math.abs(numbers[2] - numbers[0]),
            y = +Math.abs(numbers[3] - numbers[1]);

        distance = Math.sqrt(x*x + y*y).toFixed(2);
        return distance;
    }

    a = CalcDistance(a);
    b = CalcDistance(b);
    c = CalcDistance(c);
    // print distances on a new line
    distances.push(a, b, c);
    for (dist in distances) {
        console.log(distances[dist]);
    }

    function CheckTriangle(a, b, c) {
        var isTriangle,
            result;
        // a+c>b, c+b>a, a+b>c
        if (a + c > b && c + b > a && a + b > c) {
            isTriangle = true;
        }
        result = isTriangle ? 'Triangle can be built' : 'Triangle can not be built';
        return result;
    }

    var output = CheckTriangle(a, b, c);
    console.log(output);
}
// Test
solve(['5', '6', '7', '8',
    '1', '2', '3', '4',
    '9', '10', '11', '12']);

solve(['7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123']);