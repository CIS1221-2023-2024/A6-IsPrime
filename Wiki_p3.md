# Comparing The Results
In this section, we will be comparing the Speed and the memory used between different algorithms of the same language, and between the 2 languages (C# and Python)  
The different algorithms are:
- iteration
- Recursion 
- Other Primality Methods
  
These will be tested using inputs spanning from 0 up to hundreds of thousands to check which algorithms are superior when executing smaller numbers or larger numbers.
To ensure fairness, the same numbers were inputted. The following numbers were used:
  
- 0 - To check how quickly the algorithms could return nothing  
- 2 - Checking how fast the first prime number could be found  
- 35 - A small non-prime number that is not divisible by 2  
- 53 - A small prime number  
- 1,153 - A larger prime number  
- 1,357 - A larger non-prime number  
- 10,069 - A 5-digit prime number  
- 10,197 - A 5-digit non-prime number  
- 100,129 - A 6-digit prime number  
- 102,676 - A 6-digit non-prime number   
- 601,831 - A larger 6-digit prime number  
- 700,239 - A larger 6-digit non-prime number  


## Comparison within Python
The algorithms written in Python will be compared to find which algorithms are superior

### Execution Speeds
To test the execution speeds of the algorithms, the timeit module was used to find the time taken to execute. Since the execution speeds are not always the same, a rough average was taken  
Every number was tested in the algorithms, and the speeds were noted down in this Excel datasheet:
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/7696639d-fe51-4ccc-bfd7-fcce9f2bade3)


the / denotes that the algorithm could not handle that input and the µs denotes a microsecond which equates to 0.000001 of a second

### Is Prime Methods
  
From observing the results, when working with the main algorithms to check for primality, while trying to find a non-prime number, with Iteration and Recursion there is only a small difference in speeds with Iteration being almost always faster. However, when the input is a prime number, the iteration algorithm came out to be much faster than recursion.   
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/98a98314-2f2f-400e-890e-61c67cfab7f5)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/f7feadf7-1284-4956-b408-e8e9f4721e87)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/c9adce23-6418-42f9-83a7-272a066c2a48)

The Miller-Rabin algorithm was significantly slower than iteration when working with small numbers, however when the numbers got very large, the Miller-Rabin came to be significantly faster. ![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/c411b3a7-3484-43d9-9f41-c6999ff16309)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/2d84078e-f9ca-4227-93f7-c90ddf6fa294)
  
The Fermat Method was faster than the Miller-Rabin using small numbers, however even when the number enters the thousand mark, it starts to execute much slower  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/594449ad-a4e8-4018-ac44-e2a2d707fa0f) number = 35  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/fe4742ac-a130-43a7-8b81-b07add4a0620) number = 100129

### Finding all prime factors
In this algorithm, Recursion only ever was faster when checking for 0 or 2, it was much slower than iteration and stopped computing after the number 1357  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/6f908fc9-1259-47a5-b948-6b994db9e9f6)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/f80084c9-8181-4924-8724-c4734f6a4035)

### all primes up to
The iteration is significantly faster than recursion in every occurence 
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/b3bea3a2-89b5-4ea5-9833-cda67a141cbb)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/a8ceba7c-1166-46e3-abe7-68c85b4b29f4)

When working with small numbers, the Sieve Of Eratosthenes is slower than with iteration, however as the number becomes larger and larger, it also becomes much faster  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/6ef72e77-6d97-4fa5-bbd3-5d15b94f3e64)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/d3ce63c2-f8c7-4a8c-b566-bb032e9da824)

### Nth prime
As shown from the previous algorithms, the iteration came out on top with speeds twice as fast in this case, and the recursion stopped working after the number 53  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/0964151c-74f5-4cfd-a0b8-9bda2a7837f1)

### Memory Used
The memory profiler module was used to calculate the memory used by the isprime algorithms. A profile was created to check the memory used  
All the algorithms (Iterative, Recursive, Millar-Rabin and Fermat Method) all use roughly 23Mb
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/0d082eaf-a3c2-444e-b2a1-b8d75c35cfed)

### Conclusion 
For finding prime numbers, Iterative programming is not only much faster than Recursive programming, but it also is able to execute with much larger numbers.  
The Millar-Rabin also proved to be very fast and efficient when it came to checking the primality of very large numbers with over 30-digits.  
The Sieve Of Eratosthenes also proved to be fast and efficient when it came to finding a list of prime numbers when the nuber given was large.  
Memory was not so important as all the functions used roughly the same amount of memory to execute 

## Comparison within C#





## Comparison of Python vs C#  
The results from both the Python and C# languages will be compared to find which language is superior when it comes to finding prime numbers  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/ef609060-41b5-4cc0-80d0-6284a32fe6f3)
