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
  
From observing the results, when working with the main algorithms to check for primality, while trying to find a non-prime number or working with small numbers, with Iteration and Recursion there is only a small difference in speeds with Iteration being almost always faster. However, when the input is a prime number, the iteration algorithm proved to be much faster than recursion.   
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/98a98314-2f2f-400e-890e-61c67cfab7f5)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/f7feadf7-1284-4956-b408-e8e9f4721e87)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/c9adce23-6418-42f9-83a7-272a066c2a48)

The Miller-Rabin algorithm was significantly slower than iteration when working with small numbers, however when the numbers got very large, the Miller-Rabin proved be significantly faster.  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/c411b3a7-3484-43d9-9f41-c6999ff16309)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/2d84078e-f9ca-4227-93f7-c90ddf6fa294)
  
The Fermat Method was faster than the Miller-Rabin using small numbers, however even when the number enters the thousand mark, it starts to execute much slower  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/594449ad-a4e8-4018-ac44-e2a2d707fa0f) number = 35  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/fe4742ac-a130-43a7-8b81-b07add4a0620) number = 100129

### Finding all prime factors
In this algorithm, Recursion only ever was faster when checking for 0 or 2, it was much slower than iteration and stopped computing after the number 1357  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/6f908fc9-1259-47a5-b948-6b994db9e9f6)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/f80084c9-8181-4924-8724-c4734f6a4035)

### all primes up to
The iterative algorithm is significantly faster than the recursive algorithm in every occurence 
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/b3bea3a2-89b5-4ea5-9833-cda67a141cbb)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/a8ceba7c-1166-46e3-abe7-68c85b4b29f4)

When working with small numbers, the Sieve Of Eratosthenes is slower than the iterative algorithm, however as the number got larger and larger, it also became much faster  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/6ef72e77-6d97-4fa5-bbd3-5d15b94f3e64)
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/d3ce63c2-f8c7-4a8c-b566-bb032e9da824)

### Nth prime
Similarly as shown from the previous algorithms, the iterative algorithm proved to be superior with speeds twice as fast in this case, and was able to compute with much larger numbers, unlike the recursive algoritm  where it stopped working after the number 53  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/0964151c-74f5-4cfd-a0b8-9bda2a7837f1)

### Memory Used
The memory profiler module was used to calculate the memory used by the isprime algorithms. A profile was created to check the memory used  
All the algorithms (Iterative, Recursive, Millar-Rabin and Fermat Method) all use roughly 23Mb
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/0d082eaf-a3c2-444e-b2a1-b8d75c35cfed)

### Conclusion 
For the task of finding prime numbers, Iterative programming not only outperforms Recursive programming in terms of speed but also demonstrates superior performance with significantly larger numbers.  
The Millar-Rabin algorithm has proven to be exceptionally fast and efficient, particularly in checking the primality of numbers even after exceeding 30 digits.  
Similarly, the Sieve Of Eratosthenes has demonstrated speed and efficiency, especially when generating a list of prime numbers for large input values.  
Notably, memory usage is consistent across these methods, making it a less decisive factor in their comparison.

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/ab7b378c-e3ec-4136-a3b3-15e22a50ad4b)

![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/60e259b2-e95d-4f57-85fa-b5b2fad6ad9f)

## Comparison within C#
### Execution Speeds
A Stopwatch Function has been Implimented to test each end every algorithm with multiple inputs representing Primes and not Primes. Inputs are similiar to Python to keep an accurate Comparison
![Screenshot 2024-01-12 105105](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/dba77dd7-902f-4541-b3ec-18352babbe96)

From this sheet, we can denote that the **fastest** algorithms belong to the **Miller-Robin** and the **Fermat** methods, achieving remarkable speeds as low as 0.0000001 seconds. In contrast, the **slowest** algorithm, Nth Prime, takes 11 seconds to complete. It's important to acknowledge that some records are omitted due to the recursive limit inherent in the language, preventing the function from iterating infinitely and impacting the inclusion of specific algorithmic records in the analysis. To add on, the data clearly demonstrates that recursive algorithms exhibit faster execution speeds than their iterative counterparts. However, it's unfortunate that recursive algorithms face limitations when handling larger numbers. In summary, recursion is advantageous for speed, while iteration is better suited for handling larger inputs.

### Memory Used
Using the Process.GetCurrentProcess Function, the memory used is calculated which ranges about **12** to **13** Mib throught out all paradigms and all algorithms which is almost half as much as python uses.

![Screenshot 2024-01-12 122428](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/50029cd1-b2d3-4803-967c-2cf76632498e)

### Conclusion
In the presented bar charts, an examination reveals that, when evaluating the performance for the input value 1, the iterative algorithm exhibits the slowest execution time, while the Fermat algorithm demonstrates the fastest. **However, it is important to note that the bar chart representing the value 601831 has been altered for enhanced visual clarity and does not accurately reflect the corresponding execution times.**

Specifically for the input value 601831, both the Fermat and Miller algorithms exhibit the fastest execution times, whereas the iterative algorithm persists as the slowest performer. It is worth acknowledging that the recursive method is constrained by its recursive limit, which results in data collection solely from a singular information source, as other sources surpass the recursive limit.

In short, the examination of bar charts indicates that Iterative has the slowest execution time, while Miller and Fermat algorithms perform exceptionally well. Recursive is effective for smaller numbers but becomes less efficient for larger inputs due to its recursive limit. Notably, Fermat stands out as the top performer for smaller numbers, whereas Miller excels for larger input values.

![BB](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/fcc7477a-0aa8-4f66-b641-c3ea16ed9668)
![BB4](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/ea9caf9f-371f-4280-86cf-662d705537b7)
**The chart below is the accurate execution speed of the number 601831**
![BB3](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150073705/a7740b74-45cb-4294-a9bd-f08e87d7f7b9)

## Comparison of Python vs C#  
The results from both the Python and C# languages will be compared to find which language is superior when it comes to finding prime numbers  
![image](https://github.com/CIS1221-2023-2024/A6-IsPrime/assets/150345446/ef609060-41b5-4cc0-80d0-6284a32fe6f3)

### Execution Speeds

The examination of execution speeds between C# and Python yields a nuanced insight into their performance characteristics. Overall, the data reveals a striking similarity in the execution speeds of the two programming languages, with distinctions emerging prominently in the realm of specific algorithms. Notably, C# demonstrates a performance edge when handling lower numerical values, showcasing its efficiency in scenarios involving smaller numbers. Conversely, Python takes the lead in execution efficiency when dealing with larger numerical inputs, exemplifying its strength in computations involving more substantial data sets.

A deeper analysis unveils the particular algorithms contributing to these performance variations. C#'s Fermat and Miller-Rabin algorithms emerge as standout performers for tasks involving smaller numerical values. On the other hand, Python's IsPrime Recursive algorithm exhibits remarkable proficiency in computing larger prime numbers.

### Memory Usage
The comparison of memory usage between C# and Python offers a clear winner, with C# demonstrating a distinct advantage. Specifically, when executing tasks related to prime numbers, C# operates with a memory footprint of approximately 12-13 MB, notably more efficient compared to Python, which consumes around 24 MiB, equivalent to 24-25 MB. In this aspect, C# emerges as the superior performer, showcasing a more economical use of memory resources during prime number computations.

### Breaking Point
As outlined in the earlier discussion, the breaking points for C# and Python exhibit notable similarity. However, a crucial distinction emerges regarding the recursive upper bounds provided by each language. C# surpasses Python in this aspect, showcasing a significantly higher recursive upper limit, capable of reaching numbers tenfold greater than Python can achieve. This observation suggests that, depending on the algorithm and a preference for recursive approaches, C# proves to be the preferable choice, offering a broader and more scalable range for computations compared to Python.

## Conclusion
In conclusion, the decision to choose between C# and Python for prime number computations is highly subjective and dependent on the specific context of the task. C# excels in recursive and lower-number scenarios, while Python showcases superior performance with larger numbers. Importantly, C# achieves this while utilizing only half the memory compared to Python. Ultimately, the optimal choice is dictated by the unique requirements of the situation. Beyond the technical comparisons, the project was an enjoyable learning experience for developers Jake and Jurgen, providing insights into algorithm exploration and fostering a deeper understanding of both languages. In essence, this project was a rewarding and fun endeavor that expanded their knowledge and skills, particularly in the realm of GitHub collaboration.
