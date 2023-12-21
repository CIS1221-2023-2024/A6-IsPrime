''' 
Aim: This file was put up to test the execution times and boundaries of two recurisve isPrime algorithms

Observations: When run, the alternative algorithm I provided tended to be a lot quicker when dealing with larger numbers generally.
              Furthermore, the original algorithm could only find primes up to around 1008, then resulting in error when dealing with any larger number.                
              The algorithm I provided could calculate all primes up to 939193.
              While not purely recursive, it still incorporates elements of recursion. 
              
Conclusion: Since there is a significant difference in capabilities, I decided to change the code.'''

import timeit

n = int(input('Enter number: '))

# alternative algorithm
def isPrime(n, i = 2):

    if (n <= 2):
        return True if(n == 2) else False
    if (n % i == 0):
        return False
    if (i**2 > n):
        return True
    # if n is not prime, it must have a divisor smaller than or equal to its square root

    # Check for next divisor
    return isPrime(n, i + 1)

if (isPrime(n)):
    print("True. This number is prime.")
else:
    print("False. This number is not prime.")
    
start_time = timeit.default_timer()
result_alternative = isPrime(n)
alternative_time = timeit.default_timer() - start_time

print("Using alternative algorithm took:", alternative_time)

# original algorithm
def is_prime(num, div=0): #A function to check if a number is prime
    
    try:
        if num <= 1:
            return False #any number smaller or equal to 1 is not prime
        
        if div == 0: #div = num-1 is not allowed in parameter due to num not being instantialized, so we use this to assign div = num-1
            div = num - 1
        
        if div == 1: #if no returns have happened so far, that means the number is prime
            return True 

        if num % div == 0: #checks if num is perfectly divisble by div
            return False #any number divisible by another number excluding 1 or itself is not prime
    
    except RecursionError:
        print("Recursion depth exceeded. Number is too large.")
        return False
    
    return is_prime(num, div - 1) #the function is returned again recursively with div being decremented    

if (is_prime(n, div =0)):
    print("True. This number is prime.")
else:
    print("False. This number is not prime.")

start_time = timeit.default_timer()
result_original = is_prime(n, div=0)
original_time = timeit.default_timer() - start_time

print("Using original algorithm took:", original_time)

# ----------------------------------------------------------------------------------------
