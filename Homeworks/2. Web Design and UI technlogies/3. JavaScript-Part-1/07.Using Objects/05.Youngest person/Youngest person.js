/**   Youngest person
 *Write a function that finds the youngest person in a given
 * array of people and prints his/hers full name. Each person has properties firstname, lastname and age.
 Example:
 var people = [
 { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname: 'Bay', lastname: 'Ivan', age: 81 },
 { firstname: 'John', lastname: 'Doe', age: 42 }
 ];
 */
function FindYoungest(args) {
    var people = args.length,
        i,
        arr = [];

    for (i = 0; i < people; i += 3) {
        var person = (args[i] + " " + args[i + 1] + " " + args[i + 2]);
        arr.push(MakePerson(person));
    }

    function MakePerson(fields) {
        var splited = fields.split(' '),
            firstName = splited[0],
            lastName = splited[1],
            age = splited[2];

        var person = {
            firstName, lastName, age
        }

        return person;
    }

    var young = arr.reduce(
        function (a, b) {
            return a.age <= b.age ? a : b;
        });

    console.log(young.firstName + ' '+young.lastName);
}

// Test
FindYoungest(['Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
]);

FindYoungest([
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
]);