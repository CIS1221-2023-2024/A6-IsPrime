import timeit  #timeit module to check execution times

def is_prime(num,i=2): #function that checks if number in parameter entered is a prime
    
    if num <= 1: #Anything smaller than 1 is not prime
        return False
    
    while i*i <= num: #if num is not prime, it must have a divisor smaller than or equal to its square root

        if num % i == 0: #Checks if num is divisible by i 
            return False
        i += 1 #Incrementing i

    return True #if i squared is greater than num, then num has to be prime

def all_primes_up_to(max_num):

    Primes_List = [] #initializing the list of primes up till a number
    for num in range(2,max_num+1): # loops from 2 till the number entered

        if is_prime(num):               
            Primes_List.append(num) #adds the number in the list
                 
    return Primes_List #returns the list of all the primes

def find_all_prime_factors(max):

    List_of_prime_factors = []
    for num in range(2,max):
        
        if max % num == 0 and is_prime(num): #checking for factors and if is prime
            List_of_prime_factors.append(num)

    return List_of_prime_factors

def nth_prime(size, i = 2): #i is 2 since 2 is the smallest prime number possible

    if size == 0: #there is no 0th prime
        return None

    List_of_primes = [] #initializing the list of primes

    while len(List_of_primes) < size: #will keep looping till there are as many values in the list as indicated by size

        if is_prime(i): #checking whether i is a prime number
            List_of_primes.append(i) #adds the number in the list
        
        i += 1 #increments i

    return List_of_primes[-1]

def primes_in_range(start, end):
    
    if start > end: #Checks if limit is inccorect
            print("Limits are incorrect")

            return None

    primes = []
    for num in range(start, end + 1):
        if is_prime(num):
            primes.append(num)
    return primes
     
def menu(option = 0): 

    while(option != 6): #loops until exit is chosen

        option = is_int(input("\n1. Check if number is prime\n2. Find all prime factors of a number\n3. Find the nth prime ...\n4. Find a given number of n primes\n5. Find primes in range\n6. Exit \n"))   
        # input ensured to be an integer
        
        if option == 1: #if 1 is entered the following code is to be executed

            number = is_int(input("Enter number you want to check is prime: "))
            # input ensured to be an integer
            
            if is_prime(number):
                print(f'{number} is prime.')
            else: 
                print(f'{number} is not prime.')

        elif option == 2: 
            number = is_int(input("Enter number to find its prime factors: "))
            print(f'Prime factors of {number} are: {find_all_prime_factors(number)}')

        elif option == 3: 
            number = is_int(input("Enter number that you want to find the prime numbers up to: "))
            print(f'All primes up to {number} are: {all_primes_up_to(number)}')
    
        elif option == 4: 
            number = is_int(input("Enter the nth prime you want to find"))
            print(f'The {number}th prime is: {nth_prime(number)}')

        elif option == 5:
            low = is_int(input('Enter lower range.\n'))
            up = is_int(input('Enter upper range.\n'))
            print(f'Primes between {low} and {up} are {primes_in_range(low, up)}') 
        
        elif option == 6:
            print('Exiting.')
            
        else: 
            print('Incorrect number inputted.')

def is_int(num): #function to check if an entered number is an integer

    while not isinstance(num, int): #checks if num is not an integer

        try: #tries to run the following code
               num = int(num)

        except ValueError: #if error ValueError occurs, then the number is not an integer
                print("The value you entered is not an integer, please enter a valid integer")
                num = input()
    return num

 #executes the menu function
menu()

def time_check(n): #Function to test the execution times of every algorithm

    # Finding time for is_prime
    start_time = timeit.default_timer()
    is_prime(n)
    final_time = timeit.default_timer() - start_time

    print(f"The is_prime algorithm with n = {n} and using iteration took: ", final_time)

    # Finding time for find_all_prime_factors
    start_time = timeit.default_timer()
    find_all_prime_factors(n)
    final_time = timeit.default_timer() - start_time

    print(f"The find_all_prime_factors algorithm with n = {n} and using iteration took: ", final_time)

    # Finding time for all_primes_up_to
    start_time = timeit.default_timer()
    all_primes_up_to(n)
    final_time = timeit.default_timer() - start_time

    print(f"The all_primes_up_to algorithm with n = {n} and using iteration took: ", final_time)

    # Finding time for nth_prime
    start_time = timeit.default_timer()
    nth_prime(n)
    final_time = timeit.default_timer() - start_time

    print(f"The nth_prime algorithm with n = {n} and using iteration took: ", final_time)

    # Finding time for primes_in_range
    start_time = timeit.default_timer()
    primes_in_range(0,n) #Assume lower limit is 0
    final_time = timeit.default_timer() - start_time

    print(f"The primes_in_range algorithm with n = {n} and using iteration took: ", final_time)

#n = int(input("Enter a number you want to check"))
#time_check(n)