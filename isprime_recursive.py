def is_prime(num, div=0): #A function to check if a number is prime
    
    if num <= 1:
        return False #any number smaller or equal to 1 is not prime
    
    if div == 0: #div = num-1 is not allowed in parameter due to num not being instantialized, so we use this to assign div = num-1
        div = num - 1
    
    if div == 1: #if no returns have happened so far, that means the number is prime
        return True 

    if num % div == 0: #checks if num is perfectly divisble by div
        return False #any number divisible by another number excluding 1 or itself is not prime
    
    return is_prime(num, div - 1) #the function is returned again recursively with div being decremented


def find_all_prime_factors(n,counter = 2,List_of_primes = None): #A function that shows you all prime factors of a given number
        
     if List_of_primes == None: #this is so the list is reset per loop in the menu
         List_of_primes = []

     if counter == n+1: #Checks wether the counter has reached the number given (+1 so it includes the number)
         return List_of_primes #returns the list of primes
    
     if n % counter == 0 and is_prime(counter): #checks wether counter is a factor of n and if its prime
          List_of_primes.append(counter)  #adds the value of counter to the list
          
     return find_all_prime_factors(n,counter +1, List_of_primes) #returns the method but with counter incremented


def all_primes_up_to(n,counter=2,List_of_primes = None): #A function that shows you a list of all prime numbers under n

    if List_of_primes == None: #this is so the list is reset per loop in the menu
         List_of_primes = []

    if counter == n+1: #Checks wether the counter has reached the number given (+1 so it includes the number)
         return List_of_primes #returns the list of primes

    if is_prime(counter) == True: #checks if the counter is prime
         List_of_primes.append(counter)  #adds the value of the counter in the list

    return all_primes_up_to(n, counter +1, List_of_primes) #returns the method but increments the counter


def nth_prime(n,counter = 2, List_of_primes = [],): #A function that finds the nth prime
     

     if len(List_of_primes) == n: #checks wether there are as many values in the list as given by n
         return List_of_primes[n-1] #returns the last value

     if len(List_of_primes) < n: #while there are less values in the list than n
          if is_prime(counter) == True: #checks if the value in counter is a prime
               List_of_primes.append(counter) #adds counter to the list
          
     return nth_prime(n,counter + 1) 


def menu(option = 0): 

    while(option != 5): #loops until exit is chosen

        option = input("\n1. Check if number is prime\n2. Find all prime factors of a number\n3. Find every prime number up to ...\n4. Find the nth prime\n5. Exit..\n") 
        option = is_int(option)

        if option == 1: #if 1 is entered the following code is to be executed

            number = input("Enter number you want to check if is prime ")
            number = is_int(number) #checks if the number entered is an integer
            print(is_prime(number))

        elif option == 2: #if 2 is entered the following code is to be executed
            number = input("Enter number you want to find its prime factors ")
            number = is_int(number) #checks if the number entered is an integer
            print(find_all_prime_factors(number))
            

        elif option == 3: #if 3 is entered the following code is to be executed
            number = input("Enter number you want to find the prime numbers up to ")
            number = is_int(number) #checks if the number entered is an integer
            print(all_primes_up_to(number))
    
        elif option == 4: #if 4 is entered the following code is to be executed
            number = input("Enter the nth prime ")
            number = is_int(number) #checks if the number entered is an integer
            print(nth_prime(number))

        elif option == 5:
            print("Exiting...") #exists the loop

        else: 
             print("Input has to be between 1-5") #if input is not 1-5


def is_int(num): #function to check if an entered number is an integer

    while isinstance(num, int) == False: #checks if num is not an integer

        try: #tries to run the followiung code
               num = int(num)

        except ValueError:    #if the error ValueError is shown, then the number is not an integer
                print("The value you entered is not an integer, Please enter a valid integer")
                num = input()
    return num

menu()