/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function solve() {
    return function() {
        let paramsLength = arguments.length,
            input = [arguments[0], arguments[1]].map(Number);

        if (paramsLength == 0 || paramsLength == 1) {
            throw 'Invalid input!';
        } else {
            return findPrimesInRange(input[0], input[1]);
        }

        function findPrimesInRange(from, to) {
            let primes = [];

            for (let number = from; number <= to; number += 1) {
                if (isPrime(number)) {
                    primes.push(number);
                }
            }

            function isPrime(number) {
                let index = 2;

                if (number == 2) {
                    return 1;
                } else if (number < 2) {
                    return 0;
                }

                while (index <= Math.sqrt(number)) {
                    if (number % index == 0) {
                        return 0;
                    }

                    index++;
                }

                return 1;
            }

            return primes;
        }
    }
}

module.exports = solve;