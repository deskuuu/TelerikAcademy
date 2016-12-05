/**   Remove elements
 * You will be given an array of strings. Remove all occurrences of the first element in the array in itself.
 */
function Remove(args) {
    var remove = args[0],
        output;

    function Without(arr, remove) {
        return arr.filter(function (el) {
            return el !== remove;
        });
    }

    output = Without(args, remove);
    return output.join('\n');
}
// Test
Remove(['1', '2', '3', '2', '1', '2', '3', '2']);