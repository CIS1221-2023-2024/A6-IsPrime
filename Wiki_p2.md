# Edge Cases & Breaking points
Testing Edge Cases is when extreme or unusual inputs are entered to see how the program executes, some examples would be to enter a negative number, a floating point number, or a very large number. The purpose of testing edge cases is to check whether the program can handle such extreme inputs.
  
The breaking point of the program is when the input entered is so large that the program cannot handle executing as it would be beyond its capabilities, testing the breaking point is important, as it gives us a clear limit to how far the program can go

# Edge Cases
### Python
The following were tested:
- Negative numbers in Algorithm 1 (correctly identifies anything negative as not prime)
- Negative numbers in other Algorithms (Outputs "Number has to be greater than 0")
- 0 in algorithm 1 (correctly identifies 0 as not prime)
- 0 in other algorithms (Outputs "Number has to be greater than 0")
- String (outputs "The value you entered is not an integer, please enter a valid integer")
- floating point number (Outputs "The value you entered is not an integer, please enter a valid integer")
- Smallest prime 2 (Correctly identifies as prime)
- Equal limits in algorithm 5 (if the limit is prime, it will correctly list the number, However, if the number is not prime, it will show an empty list)
- Reversed limits in algorithm 5 (Outputs "Limits are incorrect")
### C#
- Negative numbers in Algorithm 1 (correctly identifies anything negative as not prime)
- 0 in algorithm 1 (correctly identifies 0 as not prime)
- String (outputs "Invalid Input")
- floating point number gives System.formatException
- Smallest prime 2 (Correctly identifies as prime)
- Equal limits in algorithm 5 will display nothing
- Reversed limits in algorithm 5 (Outputs "Incorrect")


# Breaking Point
The breaking point for the following was tested
- Iterative algorithms
- Recursive algorithms
- Other primality algorithms

## Iterative algorithms
### Python
From the testing I performed, I found that iteration did not have a specific limit where it stopped working as it always kept computing while increasing the time taken to execute. To still find a "limit" I imposed a rule of 10-seconds, where a function could not take longer than 10 seconds to execute, if it did it would be over the "limit". 
### C#
In iterative, there are really no limits on the paradigm itself but on the language its self.
## Algorithm 1 (Is prime)
### Python
This algorithm could go up to the limits of Python itself when the number given is not prime, however, it reaches its "limit" when the prime number entered reaches the **17 digits** mark
### C#
This algorithm reaches its limit when a number containing **11 digits** is entered and gives an overflow exception.
## Algorithm 2 (All primes up to a number)
### Python
Since this algorithm will have to check for primality for every single number between 2 up to the number given, the larger the number given, the longer it will take. It reaches its "limit" when the number given is a **Lower 7 digit number**
### C#
Similiar to the isPrime Algorithm, any number with **11 Digits** will fail, that being said if a number has **10 digits** it will not fail but will take a great amount of time to display
## Algorithm 3 (Nth Prime)
### Python
Since the nth prime finds every prime number up to the number given and then returns the last value, it will have a lot of numbers to add to a list and therefore its limit is reached earlier than the other algorithms, it reaches its "limit" when the number given is a **Lower 6 digit number**
### C#
After reaching the **six-digit** range, any number with more digits takes longer than one second to compute, while **six-digit** numbers take only 0.3 seconds."
## Algorithm 4 (Prime Factors)
### Python
This algorithm while having to check for 2 criteria instead of just finding prime, was faster than most of the others. It reached its "limit" when the number given is a **Lower 9 digit number**
### C#
This algorithm stays efficiant up till **7 digits**, **8 digits** take 5 seconds or more, meaning this algorithm is faster than others.
## Algorithm 5 (Prime numbers between limits)
### Python
Since this algorithm required 2 numbers instead of 1, the lower limit is given to be 0 and the upper limit is the one to be tested. Due to this case, it works the same as algorithm 2. It reaches its limit when the number given is a **Lower 7 digit number** 
### C#
Given a min of 0 to a max of an **8 digit number**, execution time took around 5 seconds (without displaying), with displaying it took 40 seconds. This means that for an efficiant execution time, **7 digits is best**

## Recursive algorithms
### Python
Unlike in iteration, there is a clear limit when working with recursion. While the recursive limit can be changed using the sys module, for testing purposes, it was left as the default limit Python has. When the number given could no longer be executed due to the Recursive limit reached error, it has exceeded its limit
### C#
Similair to pythons explanation, the recursive limit of c# depends of the avalible stack space. The recursion limit is not a fixed number like in some other programming languages; instead, it depends on the size of the stack and the amount of stack space each recursive call consumes.

## Algorithm 1 (Is prime)
### Python
Since the square root method is being used instead of the brute force method, this algorithm can work with the square of the recursion limit. This algorithm stops working after the number **8765423**
### C#
The limit was reached when entering a **10 digit number** with the first number being 1, if the first number is 2 or more the program will fail.

## Algorithm 2 (All primes up to a number)
### Python
This algorithm stops working after the number **2926**
### C#
This program fails after reaching **10000** (rough estimate but **11000** fails)

## Algorithm 3 (Nth Prime)
### Python
Since this algorithm requires a lot of resources, it will stop working earlier than the other algorithms. This algorithm stops working after the number **422**
### C#
The program stops working around **1000** and fails definitely on **1100**

## Algorithm 4 (Prime Factors)
### Python
This algorithm stops working after the number **2928**
### C#
The program stops working around **10000** and fails definitely on **11000**

## Algorithm 5 (Prime numbers between limits)
### Python
Again since this algorithm is the same as algorithm 2 due to starting from 0, its limit is the same at the number **2926**
### C#
The program stops working around **10000** and fails definitely on **11000**
  
## Other Primality Algorithms
### Python
Just like in Iteration, there is no clear limit where a number stops being computable, so the same 10 second rule will be used
### C#
Same as iterative

## Sieve of Eratosthenes
### Python
This algorithm does the same job as algorithm 2 but is faster and more efficient. The Sieve of Eratosthenes algorithm reaches its "limit" when the number given reaches the **mid 8 digit** mark.
### C#
Similiar to python, this algorithm's limit is **8 digits**, after a great amount of time, the program will crash  

## Millar-Rabbin
### Python
The Miller-Rabin algorithm had **no limit** itself, when tested with very large numbers with 30+ digits, it still computed in less than a second. It stops working when the number is so large that it is no longer supported by the int variable
### C#
This algorithm's only limit is how much the int variable can hold digits (**which is 10**) meaning withouth this, it has no limits

## Fermat Method
### Python
The Fermat method reached its limit much quicker than the other isprime algorithms (excluding recursively). It reaches its "limit" when the number given reaches the **upper 6 digit** mark
### C#
This method reaches it's limit around **6 digits**. **Note:** The Fermat primality test, while a useful probabilistic algorithm, may exhibit limitations when applied to numbers with a magnitude of around 5 to 6 digits. In some cases, prime numbers within this range could be erroneously labeled as composite (false negatives). However, it should be emphasized that the Fermat test tends to provide accurate results for numbers with five digits or fewer. For increased reliability in primality testing, especially for larger numbers, consideration of alternative algorithms such as the Miller-Rabin test

# Conclusion
When comparing the execution performance of iterative and other primality methods in both C# and Python, it is observed that they exhibit similar performance characteristics. However, a notable distinction arises when considering recursive implementations. C# tends to demonstrate a significantly higher breaking point in terms of recursion depth compared to Python. This discrepancy can be attributed to differences in how the two programming languages manage stack space during recursive function calls.
