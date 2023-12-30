# Project Definiton

## What is a prime number?

A prime number is a natural number greater than 1 that is divisible only by 1 and itself. Examples include 2, 3, 5, and 7. These numbers are fundamental in number theory, forming the basis for expressing other integers through prime factorization.  
**Note:** There are infinitely many prime numbers. 

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/b38eaee3-1c70-4d46-bbcb-6ad35eb78e8f)

## Project Aim
This project delves into the vast nature of prime numbers, showcasing diverse methods to discover and apply them. From classical techniques like the Sieve of Eratosthenes to modern algorithms, it explores efficient ways of finding primes. 

This project involves two languages: CSharp, managed by Jake, and Python, overseen by Jurgen. Each language will be implemented using two paradigms, iteratiion and recursion. The primary focus is on exploring variousexamples to efficiently discover prime numbers. The objective is to compare the performance of these two languages in handling prime number calculations by assessing their speed. The project aims to provide insights into the efficiency of different language-paradigm combinations when dealing with prime number computations.

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/83dd9ea6-5816-40e1-a9e9-555d102592fc)

## Project Algorithms
### Algorithm 1: Prime Checking
This is the foundation of the project. As the name suggests, it verifies whether a given number is prime or not. While the raw code might differ based on language or paradigm, the underlying 
concept remains consistent.
### Algorithm 2: All Primes Leading to a number
This Algorithm will be given a number and it will display all the prime numbers before that given number.  
### Algroithm 3: Find the nth Prime
This is a very interesting algorithm. It works similiar to algorithm 2 but with a twist. The number given will be the nth Prime, meaning if 10 was given, the 10th prime which would be 29 is displayed.
### Algroithm 4: Prime Factors of a Number
This Algorithm will be given a number, and displays any factors of that number than are prime, meaning if 12 was given, 2 and 3 will be displayed.  
### Algorithm 5: All Prime numbers between 2 limits  
This algorithm will be given 2 numbers, a lower limit, and an upper limit, The algorithm will then find every prime number between these 2 limits  
  
![what-is-an-algorithm](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/478a473c-16fa-463e-b62f-aed85c88bd44)
  
## Other Primality Algorithms
There exist other primality algorithms that were discovered hundreds or even thousands of years ago, the 3 following Algoirthms will be referenced in this project:  
- Sieve of Eratosthenes 
- Miller-Rabin Primality
- Fermat Method

### Sieve of Eratosthenes
This Algorithm is fairly basic, being discovered in the third-century BCE by the Greek mathematician Eratosthenes. It starts by creating a list starting from 2 up till any number n, since 2 is prime (Axiom rule), then any number multiplied by 2 (2n), is composite (Not Prime). So every 2n number excluding 2 itself is removed from the list, the next number naturally would be 3, since 3 is still in the list, that means it is also a prime number. The same is done as previously and any 3n is removed from the list, this is done until every number in the list is either a Prime number or a Composite number  
![ezgif com-speed](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/03e697f4-dd06-4c59-8a0c-2ddc69082fa4)  

### Miller-Rabin Primality
The Miller-Rabin Primality test is a more modern mathematical Algorithm to find if a number is probably prime, being discovered in 1976 by Gary L.Miller, and then later refined by Michael O. Rabin in 1980. There are 3 main steps in this algorithm.
- Step 1: Find n-1 = 2<sup>k</sup> * m
Think of any natural number that you want to check if it is probably prime, that will be n, then subtract n by 1. Then keep dividing the number obtained by 2 until it is no longer a whole number. The number of times n-1 can be divided by 2 without resulting in a decimal point will be m.
- Step 2: Choose a (1 < a < n-1)
Pick any number between 1 and n-1, that will be a
- Step 3: Compute b<sub>0</sub> = a * m modn (b<sub>i</sub> = b<sub>i-1</sub><sup>2</sup>)  
Work out a * m modulus n, if the answer is 1 or n-1, then it is probably prime, if the answer is neither we need to continue
b<sub>i</sub> = b<sub>i-1</sub><sup>2</sup> so then instead we do b<sub>2</sub> = b<sub>1</sub><sup>2</sup> mod n, if the answer is 1, then the number is composite, if the answer is n-1, then it is probably prime, and if it is neither, we apply the same step till we get 1 or n-1  

### Fermat Method 
The Fermat method was discovered by Pierre de Fermat in 1640, it states that if p is prime and a is not divisible by p, then a<sup>p-1</sup> ≡ 1 mod p  
Think of any natural number that you want to check if it is probably prime, that will be p, now think of another number that is not divisible by p, that will be a, if a<sup>p-1</sup> ≡ 1 mod p holds true, then p is probably prime
