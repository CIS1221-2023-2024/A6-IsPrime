''' 
Aim: to test prime factorization features

Observations: Alternative algorithm can caluclate slightly faster, also the prime factors of a wider range of numbers without giving an error
              Alternative algorithm can go over 100,000 while other cannot go over 970.
             
Conclusion: I have changed the algorithms given the wider capabilities of the alternative algorithm.'''

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

#alternative algorithm
def prime_factors(n, factor=2):
    if n <= 1:
        return []
    
    prime_factors_list = []

    while factor <= n:
        if n % factor == 0 and isPrime(factor):
            prime_factors_list.append(factor)
            return prime_factors_list + prime_factors(n // factor, factor)
        factor += 1
    
    return prime_factors_list

start_time = timeit.default_timer()
result_alternative = list(set(prime_factors(n)))
alternative_time = timeit.default_timer() - start_time
print(f"Alternative algorithm prime factors of {n}: {result_alternative}")

#original algorithm
def find_all_prime_factors(n,counter = 2,List_of_primes = None): #A function that shows you all prime factors of a given number
        
     if List_of_primes == None: #this is so the list is reset per loop in the menu
         List_of_primes = []

     if counter == n+1: #Checks whether the counter has reached the number given (+1 so it includes the number)
         return List_of_primes #returns the list of primes
    
     if n % counter == 0 and isPrime(counter): #checks wether counter is a factor of n and if its prime
          List_of_primes.append(counter)  #adds the value of counter to the list
          
     return find_all_prime_factors(n,counter +1, List_of_primes) #returns the method but with counter incremented

start_time = timeit.default_timer()
result_original = find_all_prime_factors(n)
original_time = timeit.default_timer() - start_time
print(f"Original algorithm prime factors of {n}: {result_original}")

print("\nUsing alternative algorithm took:", alternative_time)
print("Using original algorithm took:", original_time)