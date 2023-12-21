''' 
Aim: This file was put up to test the execution times of finding nth prime algorithms. Algorithms are similar in structure, although one uses a list and another does not.

Observations: Both algorithms seem to break off after the 163rd prime number, similar execution times.

Conclusion: Decided that original code will be kept'''

import timeit

n = int(input('Enter number:'))

def isPrime(n, i = 2):

    if (n <= 2):
        return True if(n == 2) else False
    if (n % i == 0):
        return False
    if (i**2 > n):
        return True
    
    return isPrime(n, i + 1)

#  alternative algorithm
def find_nth_prime(n, current=2, count=0):
    if count == n:
        return current - 1
    elif isPrime(current):
        return find_nth_prime(n, current + 1, count + 1)
    else:
        return find_nth_prime(n, current + 1, count)

start_time = timeit.default_timer()
result_alternative = find_nth_prime(n)
alternative_time = timeit.default_timer() - start_time
print(f"Alternative algorithm {n}th prime: {result_alternative}")

#original algorithm
def nth_prime(n,counter = 2, List_of_primes = [],): #A function that finds the nth prime
     

     if len(List_of_primes) == n: #checks wether there are as many values in the list as given by n
         return List_of_primes[n-1] #returns the last value

     if len(List_of_primes) < n: #while there are less values in the list than n
          if isPrime(counter) == True: #checks if the value in counter is a prime
               List_of_primes.append(counter) #adds counter to the list
          
     return nth_prime(n,counter + 1) 
 
start_time = timeit.default_timer()
result_original = nth_prime(n)
original_time = timeit.default_timer() - start_time
print(f"Original algorithm {n}th prime: {result_original}")

print("Using my algorithm took:", alternative_time)
print("Using original algorithm took:", original_time)
