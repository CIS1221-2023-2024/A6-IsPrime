# Project Definiton

## What is a prime number?

A prime number is a natural number greater than 1 that is divisible only by 1 and itself. Examples include 2, 3, 5, and 7. These numbers are fundamental in number theory, forming the basis for expressing other integers through prime factorization.  
**Note:** There are infinitely many prime numbers. 

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/b38eaee3-1c70-4d46-bbcb-6ad35eb78e8f)

## Project Aim
This project delves into the vast nature of prime numbers, showcasing diverse methods to discover and apply them. From classical techniques like the Sieve of Eratosthenes to modern algorithms, it explores efficient ways of finding primes. 

This project involves two languages: CSharp, managed by Jake, and Python, overseen by Jurgen. Each language will be implemented using two paradigms, iteration and recursion. The primary focus is on exploring variousexamples to efficiently discover prime numbers. The objective is to compare the performance of these two languages in handling prime number calculations by assessing their speed. The project aims to provide insights into the efficiency of different language-paradigm combinations when dealing with prime number computations.

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/83dd9ea6-5816-40e1-a9e9-555d102592fc)

## Project Algorithms
### Algorithm 1: Prime Checking
This is the foundation of the project. As the name suggests, it verifies whether a given number is prime or not. While the raw code might differ based on language or paradigm, the underlying 
concept remains consistent.
### Algorithm 2: All Primes Leading to a number
This Algorithm will be given a number and it will display all the prime numbers before that given number.  
### Algorithm 3: Find the nth Prime
This is a very interesting algorithm. It works similiar to algorithm 2 but with a twist. The number given will be the nth Prime, meaning if 10 was given, the 10th prime which would be 29 is displayed.
### Algorithm 4: Prime Factors of a Number
This Algorithm will be given a number, and displays any factors of that number than are prime, meaning if 12 was given, 2 and 3 will be displayed.  
### Algorithm 5: All Prime numbers between 2 limits  
This algorithm will be given 2 numbers, a lower limit, and an upper limit, The algorithm will then find every prime number between these 2 limits  
  
![what-is-an-algorithm](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/478a473c-16fa-463e-b62f-aed85c88bd44)
  
## Other Primality Algorithms
There exist other primality algorithms that were discovered hundreds or even thousands of years ago, the 3 following Algorithms will be referenced in this project:  
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
Work out a * m mod n, if the answer is 1 or n-1, then it is probably prime, if the answer is neither we need to continue
b<sub>i</sub> = b<sub>i-1</sub><sup>2</sup> so then instead we do b<sub>2</sub> = b<sub>1</sub><sup>2</sup> mod n, if the answer is 1, then the number is composite, if the answer is n-1, then it is probably prime, and if it is neither, we apply the same step till we get 1 or n-1  

### Fermat Method 
The Fermat method was discovered by Pierre de Fermat in 1640, it states that if p is prime and a is not divisible by p, then a<sup>p-1</sup> ≡ 1 mod p  
Think of any natural number that you want to check if it is probably prime, that will be p, now think of another number that is not divisible by p, that will be a, if a<sup>p-1</sup> ≡ 1 mod p holds true, then p is probably prime

## Approaches for prime checking
The 3 approaches that will be referenced are the following:
- Brute Force approach
- O(√N) method
- sympy.isprime()

### Brute Force approach
The brute force approach is a very simple method to calculate if a number is prime or not.  
It follows the basic mathematical principle of prime numbers, it checks if any given number is perfectly divisble by any number larger than 1 but smaller than itself. While this method works in finding prime numbers, it is very time inefficient when given a large number such as 1153 or 601831. This method is as efficient when working with small numbers or with non primes that have small divisors, however it is much slower when given large numbers, especially if they are prime. This method has a Big O Notation of O(n) since it will loop for the same ammount as the number provided (Given the number is prime), this means the time taken to execute this method is directly proportional to the number's size

Code Snippet:  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/6b456c8d-b6b8-44f5-a965-e97da187cd5b)

FlowChart:  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/d2dc415c-cf11-4780-95cc-129d7bb7704b)

### O(√N) method
The O(√N) method is similar to the brute force approach, however it instead follows the theorem that if a number is composite (not prime), it must have a divisor that is smaller or equal to its square root. This method is faster and more efficient than the brute force method, especially when given large numbers as instead of looping up to n, it only loops up to its square root. Like its name suggests This method has a Big O Notation of O(√N).

Code Snippet:  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/8a285013-c686-4026-898a-bc852d157fc5)

FlowChart:  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/f435da86-547d-4297-bfd4-2c418e44b7db)

### sympy.isprime() (Python)
Externally, this method is very simple. It involves importing the function isprime() from the module sympy. However internally it uses multiple techniques to work out of a number is prime. If its testing a small number, it uses a determenistic algorithm based on a list of already known prime numbers, if the number is large it switches to probabilistic primality testing using algorithms such as the previously mentioned algorithm, the Miller-Rabin test. If the import function is used outside of the function, it is a very fast way of finding primality, however if the import is placed within the function, it is significantly slower than the 2 other approaches. When using small numbers it has the big O notation of O(√N), and when the numbers are large it has the big O Notation of O(Log<sup>3</sup>(n)).  
**Note:** For the sake of the comparison, we will assume that the import is to be placed outside of the function  
  
Code Snippet:  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/214ae723-7add-4f74-a4af-d4c5940331de)

### Time Complexity

When given either very small numbers such as 1, 7, 17 etc... all methods execute in a very similar time frame at around 2-4 μs (MicroSeconds), However this greatly changes when the values entered are large prime numbers.  
For Example: When the methods are to check if the number 10069 is prime, the brute force method takes roughly 0.0003 seconds, while the square root method takes around 9 μs, and the sympy.isprime() takes around 7 μs so the square root method is ~ 3800% faster than the brute force method and the sympy.isprime() is ~ 4300% faster than the brute force method and ~ 78% faster than the O(√N) method. The massive difference grows even larger when even higher prime numbers are introduced  
  
Big O Notation Comparison  
  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/dfb9f9c9-a651-46c3-93be-f6d25d0c36b4)
  
Execution Times:  
  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/05bff409-bde8-4d42-b223-5398fa64fbfe)

