/**  Group people
 * Write a function that groups an array of people by age. The function must return an associative
 * array, with keys - the groups, and values - arrays with people in this groups Use function overloading (i.e. just one function)
 */
var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 81},
    {firstname: 'John', lastname: 'Doe', age: 42},
    {firstname: 'Pesho', lastname: 'Pesho', age: 22},
    {firstname: 'Asdf', lastname: 'Xyz', age: 81},
    {firstname: 'Gosho', lastname: 'Gosho', age: 22}
];

var groupedByAge = group(people);

//sort by age
people.sort(function(a, b) {
    return a.age - b.age;
});

console.log(people);