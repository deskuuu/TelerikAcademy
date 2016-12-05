/**  PrimeNumbers
 *Write a program that finds all prime numbers in the range [1 ... N].
 * Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.
 */
function FindPrime(args) {
    var max = +args[0],
        isPrime,
        i, j;

    for (i = N; i >= 0; i -= 1) {
        isPrime = true;

        for (j = 2; j <= Math.sqrt(i); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime === true) {
            return i;
        }
    }
}