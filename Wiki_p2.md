# Edge Cases & Breaking points
Testing Edge Cases is when extreme or unusal inputs are entered to see how the program executes, some examples would be to enter a negative number, a floating point number, or a very large number. The purpose of testing edge cases, is to check wether the program is able to handle such extreme inputs.
  
The breaking point of the program is when the input entered is so large that the program cannot handle executing as it would be beyond its capabilities, testing the breaking point is important, as it gives us a clear limit to how far the program can go

# Using Python  

## Edge Cases

## Breaking Point
The breaking point for the following was tested
- Iterative algorithms
- Recursive algorithms
- Other primality algorithms

## Iterative algorithms
From the testing I performed, I found that iteration did not have a specific limit where it stopped working as it always kept computing while increasing the time taken to execute. To still find a "limit" I imposed a rule of 10 seconds, where a function could not take longer than 10 seconds to execute, if it did it would be over the "limit". 

### Algorithm 1 (Is prime)
This algorithm could go up to the limits of python itself when the number given is not prime, however it reaches its "limit" when the prime number entered reaches the **17 digits** mark

### Algorithm 2 (All primes up to a number)
Obviously since this algorithm will have to check for primality for every single number between 2 up to the number given, the larger the number given, the longer it will take. It reaches its "limit" when the number given is a **Lower 7 digit number**

### Algorithm 3 (Nth Prime)
Since the nth prime finds every prime number up to the number given and then returns the last value, it will have a lot of numbers to add into a list and therefore its limit is reached earlier than the other algorithms, it reaches its "limit" when the number given is a **Lower 6 digit number**

### Algorithm 4 (Prime Factors)
This algorithm while having to check for 2 criteria instead of just finding prime, was faster than most of the others. It reached its "limit" when the number given is a **Lower 9 digit number**

### Algorithm 5 (Prime numbers between limits)
Since this algorithm required 2 numbers instead of 1, the lower limit is given to be 0 and the upper limit is the one to be tested. Due to this case, it works basically the same as algorithm 2. It reaches its limit when the number given is a **Lower 7 digit number** 
  


## Recursive algorithms
Unlike in iteration, there is a clear limit when working with recursion. While the recursive limit can be changed using the sys module, for testing purposes, it was left as the default limit python has. When the number given could no longer be executed due to the Recursive limit reached error, it has exceeded its limit

### Algorithm 1 (Is prime)
Since the square root method is being used instead of the brute force method, this algorith can work with the square of the recursion limit. This algorithm stops working after the number **8765423**

### Algorithm 2 (All primes up to a number)
This algorithm stops working after the number **2926**

### Algorithm 3 (Nth Prime)
Since this algorithm requires a lot of resources, it will stop working earlier than the other algorithms. This algorithm stops working after the number **422**

### Algorithm 4 (Prime Factors)
This algorithm stops working after the number **2928**

### Algorithm 5 (Prime numbers between limits)
Again since this algorithm is basically the same as algorithm 2 due to starting from 0, its limit is the same at the number **2926**

  
## Other Primality Algorithms
Just like in Iteration, there is no clear limit where a number stops being computable, so the same 10 second rule will be used

### Sieve of Eratosthenes
This algorithm does the same job as algorithm 2 but faster and more efficiently. The Sieve of Eratosthenes algorithm reaches its "limit" when the number given reaches the **mid 8 digit** mark.

### Millar-Rabbin
The Miller-Rabin algorithm had **no limit** itself, when tested with very large numbers with 30+ digits, it still computed in less than a second. It stops working when the number is so large that it is no longer supported by the int variable

### Fermat Method
The Fermat method reached its limit much quicker than the other isprime algorithms (excluding recursively). It reaches its "limit" when the number given reaches the **upper 6 digit** mark


## Using C#  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/cec82354-fc1f-4522-abeb-8ee1b4262e75)
