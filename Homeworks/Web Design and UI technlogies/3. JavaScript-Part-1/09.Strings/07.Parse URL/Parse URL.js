/**  Parse URL
 * Write a script that parses an URL address given
 * in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 * protocol: http
 server: telerikacademy.com
 resource: /Courses/Courses/Details/239
 */
function parse(args) {
    var address = args[0],
        protocol = address.split('://')[0],
        slashSplitted = address.split('://')[1].split('/'),
        server = slashSplitted[0],
        resource = '',
        i;

    for (i = 1; i < slashSplitted.length; i += 1) {
        resource += '/' + slashSplitted[i];
    }

console.log('protocol: ' + protocol);
console.log('server: ' + server);
console.log('resource: ' + resource);
}

parse(['http://telerikacademy.com/Courses/Courses/Details/239']);