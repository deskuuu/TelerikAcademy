/**  Youngest person
 * Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */
function makePerson(firstName, lastName, age, gender) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age,
        this.gender = gender ? 'female' : 'male';
}

var des = new makePerson('Desi', 'Manova', 19, true),
    de = new makePerson('Deso', 'Manov', 19, false),
    d = new makePerson('Desi', 'Manova', 19, true),
    dess = new makePerson('Desi', 'Manova', 19, true),
    desss = new makePerson('Des0', 'Manov', 10, true),
    dessy = [des, de, d, dess, desss];

var male = dessy.filter(function (item) {
    return item.gender == 'male';
});
console.log(male);