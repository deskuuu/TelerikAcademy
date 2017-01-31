/**  People of age
 * Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

var containOnly18 = dessy.every(function (a) {
    return a.age > 18;
});

console.log(containOnly18);
