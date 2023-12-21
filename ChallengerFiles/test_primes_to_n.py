''' 
Aim: to test execution times of prime numbers to a certain number

Observations: both recursive algorithms only work till up to 970

Conclusion: Execution times of original algorithm are slightly superior, will not change original code.'''

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
def find_primes_up_to_n(n, current=2, primes=[]):
    
    if current <= n:
        if isPrime(current):
            primes.append(current)
        return find_primes_up_to_n(n, current + 1, primes)
    else:
        return primes

start_time = timeit.default_timer()
result_alternative = find_primes_up_to_n(n)
alternative_time = timeit.default_timer() - start_time
print(f"Alternative algorithm primes up to {n}: {result_alternative}")

# original algorithm  
def all_primes_up_to(n,counter=2,List_of_primes = None): #A function that shows you a list of all prime numbers under n2

    if List_of_primes == None: #this is so the list is reset per loop in the menu
         List_of_primes = []

    if counter == n+1: #Checks wether the counter has reached the number given (+1 so it includes the number)
         return List_of_primes #returns the list of primes

    if isPrime(counter) == True: #checks if the counter is prime
         List_of_primes.append(counter)  #adds the value of the counter in the list

    return all_primes_up_to(n, counter +1, List_of_primes) #returns the method but incremen

start_time = timeit.default_timer()
result_original = all_primes_up_to(n)
original_time = timeit.default_timer() - start_time
print(f"Original algorithm all prime up to {n}: {result_original}")

print("\nUsing alternative algorithm took:", alternative_time)
print("Using original algorithm took:", original_time)

