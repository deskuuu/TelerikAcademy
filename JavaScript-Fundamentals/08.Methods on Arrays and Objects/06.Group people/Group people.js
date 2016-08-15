/**  Group people
 * Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */
function makePerson(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
}

var des = new makePerson('Desi', 'Nikolova'),
    mariq = new makePerson('Mariq', 'Peteva'),
    anna = new makePerson('Anna Mariq', 'Luiza'),
    marto = new makePerson('Marto', 'Martev'),
    people = [des, mariq, anna, marto];

function GroupPeopleByFirstName(people) {
    var peopleToSort = people,
        sorted = [];

    sorted = peopleToSort.sort(function (a, b) {
        return (a.firstName > b.firstName) ? 1 : -1;
    });

    console.log(peopleToSort);
}

// Test
GroupPeopleByFirstName(people);