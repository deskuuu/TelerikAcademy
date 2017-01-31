/**   Reverse string
 * Write a JavaScript function that reverses a string.
 */
function reverse(str) {
    String.prototype.reversed = function reversed() {
        var r = "";
        for (var i = this.length - 1; i >= 0; i--) {
            r += this[i];
        }
        return r;
    };

    console.log(str[0].reversed());
}

reverse(['sample']);