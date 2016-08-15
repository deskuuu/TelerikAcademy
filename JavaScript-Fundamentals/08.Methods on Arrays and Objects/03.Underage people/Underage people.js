/**  Underage people
 * Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */
function makePerson(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

var des = new makePerson('Desi', 'Manova', 19),
    de = new makePerson('Deso', 'Manov', 14),
    d = new makePerson('Desi', 'Manova', 43),
    dess = new makePerson('Desi', 'Manova', 29),
    desss = new makePerson('Desi', 'Manova', 10),
    dessy = [des, de, d, dess, desss];

function undergrade(array) {
    var condition = array.age < 18;
    console.log(condition ? array.firstName + ' ' + array.lastName + ' ' + array.age : '');
};

var containOnly18 = dessy.forEach(undergrade);
console.log(containOnly18);