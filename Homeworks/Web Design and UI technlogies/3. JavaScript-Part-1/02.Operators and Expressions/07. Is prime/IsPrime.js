/**Problem 7. Is prime
 Write an expression that checks if given positive integer number n (n ? 100) is prime.
 */

/*function CheckIsPrime(number) {
 //  (p–1)! = –1 (mod p)

 if (number == 1) return false;
 if (number == 2) return true;

 for (var divisor = 2; divisor <= Math.sqrt(number); divisor++) {
 if (!(number % divisor)) return false;
 }

 return true;
 }*/
//var check = CheckIsPrime(51);
//console.log(check);
function CheckIsPrime(number) {
    var isPrime = true,
        index;
    if (number < 2) {
        isPrime = false;
    }
    for (i = 2; i <= Math.sqrt(number); i += 1) {
        if (number % i == 0) {
            isPrime = false;
        }
    }
    return console.log(isPrime);
}