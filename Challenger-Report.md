## IsPrime – Challenger Report

### Brainstorming Session

Initially, the team and I set up a [Brainstorming Session](https://github.com/CIS1221-2023-2024/A6-IsPrime/discussions/2) on campus to discuss the scope of their project and what my role would be as a challenger. The team was very helpful in showing me how the run their project on different IDEs as I was only familiar with VS code not VS.

### Overview

The team had compiled four programs, two in Python by Jurgen and the others in C# by Jake. They both implemented prime number algorithms in the iterative and recursive paradigms. The programs all had a menu type interface that allowed the user to chose between multiple functions relating to prime numbers.

### Implementing Changes 

My aim here was to find the most efficient way of the solutions they had presented. In the [‘Challenger Files’](https://github.com/CIS1221-2023-2024/A6-IsPrime/tree/main/ChallengerFiles)  folder, I tried to implement comparision tests that would improve the project as a whole. In the [python](https://github.com/CIS1221-2023-2024/A6-IsPrime/tree/main/ChallengerFiles/PythonRecursive) part, I constructed some python scripts to highlight comparison of the algorithms and tested them using the **'timeit'** python module. Specifically, since the recursive functions are always rather limited in large numbers, and usually end up in a stack overflow. My aim building up these five files was to find the most robust algorithm that still adheres to the recursive paradigm. Any improvements were then implemented to the code in the main project itself. Here, I also indicated all the edge cases and breaking points of the system in comments. These points were pointed out to the team in the same folder I created.

While testing out the C# programs, I decided that comparing the C# algorithms was rather futile. This is since the improvements will be minimally apparent and the algorithms provided by the team were already optimized and efficient for that specific paradigm (be it iterative or recursive). Additionally, I provided the same [Primality Algorithms in C#](https://github.com/CIS1221-2023-2024/A6-IsPrime/tree/main/ChallengerFiles/CSharpTests) that the team can compare their own paradigms to, and also implement into their own project. For example, the implementation of the Sieve of Eratosthenes, which the team can then compare to the 'find prime numbers up to function' either in a recursive or iterative paradigm. I believe that these mathematical algorithms will further increase the reliability and complexity of the project itself. 

Another suggestion was to include another function in programs, finding primes within a range (instead of just up to). So, I implemented it in [Python](https://github.com/CIS1221-2023-2024/A6-IsPrime/commit/a39970298a1a17ee708547b5f77064acced6e592) and the C# part was done by the team. This allowed the user to put in a lower and upper bound, making the project find all the primes within.

Finally, I suggested that the team take a look at more formal mathematical prime number algorithm such as the **Sieve of Eratosthenes**, the **Miller-Rabin Primality** test and the **Fermat Method**. I provided an implementation of all these algorithms in [python](https://github.com/CIS1221-2023-2024/A6-IsPrime/blob/main/PrimalityAlgorithms). These mathematical phenomena helped the team look beyond the basic paradigms of working with primes, allowing them to find the most efficient and fast methods discovered in mathematics. These algorithms  go further than just the recursive and iterative paradigms, and I felt that they should be included somewhere in the project. The team can also compare the appropriate algorithms that they constructed in the recursive and iterative algorithms to these functions, in terms of edge cases, execution time, memory usage, complexity...

All these mathematical concepts were correctly implemented, documented, and understood by the team.

The team also looked into prime checking and did an effective job at analyzing, explaining, and documenting the Brute Force approach, O(√N) method and the sympy.isprime() in relevance to their project.

###	Conclusion
On the whole, they were very helpful, gave great attention to detail and always replied and reacted appropriately to any suggestions I had made, whether right or wrong. They were always successful in communicating with my input and optimizing their own work as discussed. The team made good use of coding standards, put out effective solutions with clear commenting and documentation.



