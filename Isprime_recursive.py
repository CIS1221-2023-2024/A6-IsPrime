# My take on the original Python Recursive program file uploaded by team 
import timeit

def isPrime(n, i = 2):
    try:
        if (n <= 2):
            return True if(n == 2) else False
        if (n % i == 0):
            return False
        if (i**2 > n):
            return True
        # if n is not prime, it must have a divisor smaller than or equal to its square root
    
    except RecursionError:
        print("Recursion depth exceeded. Number is too large.")
        return False
    # Check for next divisor
    return isPrime(n, i + 1)

def prime_factors(n, counter = 2, list_of_primes = None): #shows all prime factors of a given number

     if n <= 1:
        return None

     if list_of_primes == None: # list is reset per loop in the menu
         list_of_primes = []

     if counter == n+1: #Checks whether the counter has reached the number given (+1 so it includes the number)
         return list_of_primes #returns the list of primes
    
     if n % counter == 0 and isPrime(counter): #checks whether counter is a factor of n and if its prime
          list_of_primes.append(counter)  #adds the value of counter to the list
          
     return prime_factors(n,counter +1, list_of_primes) #returns counter incremented

def all_primes_up_to(n, counter=2, list_of_primes = None): #shows you a list of all prime numbers under n

    if n <= 1:
        return None

    if list_of_primes == None: # the list is reset per loop in the menu
         list_of_primes = []

    if counter == n+1: # checks whether the counter has reached the number given (+1 so it includes the number)
         return list_of_primes #returns the list of primes

    if isPrime(counter): # checks if the counter is prime
         list_of_primes.append(counter)  #adds the value of the counter in the list

    return all_primes_up_to(n, counter +1, list_of_primes) #returns the method but incremen

def nth_prime(n, counter = 2, list_of_primes = None,):   

     if n == 0: #0th prime doesnt exist
        return None

     if list_of_primes == None: # the list is reset per loop in the menu
         list_of_primes = []

    #checks whether there are as many values in the list as given by n
     if len(list_of_primes) == n: 
         return list_of_primes[n-1] # returns the last prime

     #while there are less values in the list than n, continue searching
     if len(list_of_primes) < n: 
          if isPrime(counter) == True: # checks if the value in counter is a prime
               list_of_primes.append(counter) #adds counter to the list
          
     return nth_prime(n,counter + 1,list_of_primes) # recursive call

def primes_in_range(start, end, list_of_primes = None):
    
    if list_of_primes == None: # the list is reset per loop in the menu
         list_of_primes = []

    if start>end: #Checks if the loop exceeds the upper limit
        return list_of_primes

    if start <= end:
        if isPrime(start):
            list_of_primes.append(start)
        return primes_in_range(start + 1, end, list_of_primes)
        # checks if prime for start then increments until end is reached
     
def menu(option = 0): 

    while(option != 6): #loops until exit is chosen
        print('\nEnter your choice:')
        option = is_int(input("\n1. Check if number is prime.\n2. Find all prime factors of a number.\n3. Find every prime number up to ...\n4. Find the nth prime.\n5. Find prime numbers in range.\n6. Exit. \n")) 

        if option == 1: #if 1 is entered the following code is to be executed

            number = is_int(input("Enter number you want to check if is prime: "))

            if isPrime(number):
                print(f'{number} is prime.')
            else: 
                print(f'{number} is not prime.')

        elif option == 2: # option choice
            number = is_int(input("Enter number to find its prime factors: "))
            print(f'Prime factors of {number} are: {prime_factors(number)}')
            
        elif option == 3: # option choice
            number = is_int(input("Enter number you want to find the prime numbers up to it: "))
            print(f'All primes up to {number} are: {all_primes_up_to(number)}')
    
        elif option == 4: # option choice
            number = is_int(input("Enter the nth position: "))
            print(f'The {number}th prime number is: {nth_prime(number)}')
            
        elif option == 5:
            lower_limit = is_int((input("Enter the lower limit: ")))
            upper_limit = is_int((input("Enter the upper limit: ")))
            
            if(lower_limit > upper_limit):
                print('Incorrect Values inputted.')
            print(f'Primes between {lower_limit} and {upper_limit} are {primes_in_range(lower_limit, upper_limit)}') 

        elif option == 6:
            print("Exiting program...") #exits the loop, program comes to a halt

        else: 
             print("Input has to be an integer between 1 to 6.") # boundary condition

def is_int(num): # check if input number is an integer

    while isinstance(num, int) == False:

        try: 
               num = int(num) # type check

        except ValueError:    #if the error ValueError occurs, then the number is not an integer
                print("The value you entered is not an integer, please enter a valid integer: ")
                num = input()
    return num

menu()

def time_check(n): #Function to test the execution times of every algorithm

    # Finding time for isPrime
    start_time = timeit.default_timer()
    isPrime(n)
    final_time = timeit.default_timer() - start_time

    
    print(f"The isPrime algorithm with n = {n} and using Recursion took: ", final_time)

    
    # Finding time for prime_factors
    start_time = timeit.default_timer()
    prime_factors(n)
    final_time = timeit.default_timer() - start_time

    print(f"The prime_factors algorithm with n = {n} and using Recursion took: ", final_time)

    # Finding time for all_primes_up_to
    start_time = timeit.default_timer()
    all_primes_up_to(n)
    final_time = timeit.default_timer() - start_time

    
    print(f"The all_primes_up_to algorithm with n = {n} and using Recursion took: ", final_time)

    
    # Finding time for nth_prime
    start_time = timeit.default_timer()
    nth_prime(n)
    final_time = timeit.default_timer() - start_time

    print(f"The nth_prime algorithm with n = {n} and using Recursion took: ", final_time)
     

    # Finding time for primes_in_range
    start_time = timeit.default_timer()
    primes_in_range(0,n) #Assume lower limit is 0
    final_time = timeit.default_timer() - start_time

    print(f"The primes_in_range algorithm with n = {n} and using Recursion took: ", final_time)
    

#n = int(input("Enter number"))
#time_check(n)