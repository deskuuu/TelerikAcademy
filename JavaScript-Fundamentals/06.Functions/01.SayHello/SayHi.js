/**  Say Hello
 * Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.
 */
function SayHi(args) {
    var name = args[0];

    function Hi(name) {
        return console.log('Hello, ' + name + '!');
    }

    Hi(name);
}
// test
SayHi(['Desi']);