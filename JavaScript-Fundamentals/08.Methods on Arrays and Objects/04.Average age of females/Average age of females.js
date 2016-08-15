/** Average age of females
 *Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
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
    dess = new makePerson('Deso', 'Manova', 19, false),
    desss = new makePerson('Desi', 'Manova', 19, true),
    dessy = [des, de, d, dess, desss];

dessy = dessy.map(x=>x.gender == 'female');
console.log(dessy);