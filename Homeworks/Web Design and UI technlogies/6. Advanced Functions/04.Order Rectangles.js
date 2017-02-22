/**
 * The output must consist of an array of rectangles (objects) sorted by their area in descending order as a first
 criteria and by their width in descending order as a second criteria.
 */
function order() {
    let input = arguments[0],
        rectanglesCounter = input.length,
        output = [];

    function makeRectangle(params) {
        let rectangle = {
            width: params[0],
            height: params[1],
            area: `${params[0]}` * `${params[1]}`
        };

        output.push(rectangle);
    }

    input.forEach((x)=>makeRectangle(x));
    output.sort((x, y)=>x.area < y.area);
    output.sort((x, y)=>x.width > y.width);

    return output;
}

let output = order([[10, 5], [5, 12]]);
console.log(output);
/*[{width:5, height:12, area:50},
 {width:10, height:5, area:60]*/
