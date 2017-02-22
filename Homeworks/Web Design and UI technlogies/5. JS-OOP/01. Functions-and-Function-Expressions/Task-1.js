/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function solve() {
    return function sum(numbers) {
        let numbersArray = numbers;

        if (!Array.isArray(numbersArray)) {
            throw 'Missing input!';
        } else if (numbersArray.length == 0) {
            return null;
        }

        numbersArray = numbersArray.map(Number);

        let sum = 0;
        for (let num of numbersArray) {
            if (typeof num != "number" || isNaN(num)) {
                throw 'Invalid input numbers!';
            }

            sum += num;
        }

        return sum;
    }
}

 module.exports = solve;