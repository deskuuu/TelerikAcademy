/**   Make person
 * Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
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
    desss = new makePerson('Desi', 'Manova', 19, true),
    dessy = [des,de,d,dess,desss];

console.log(dessy);
