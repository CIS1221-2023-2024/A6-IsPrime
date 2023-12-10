def is_prime(num): #function that checks if number in parameter entered is a prime
    
    
    for x in range(2,num): #loops from 2 up to number entered - 1 
        
        if num % x == 0: #checks if the number entered is perfectly divisible by x thats iterating up to num-1
           
            return False
    
    if num == 1: 
        return False 
      
    return True 

def all_primes_up_to(max_num):

    Primes_List = [] #initializing the list of primes up till a number

    for num in range(2,max_num+1): #Loops from 2 till the number entered

        if is_prime(num) == True:
                
            Primes_List.append(num) #adds the number in the list
                
    return Primes_List #returns the list of all the primes
    

def find_all_prime_factors(max):

    List_of_prime_factors = []

    for num in range(2,max):
        
        if max % num == 0 and is_prime(num) == True: #checking for factors and if is prime
            List_of_prime_factors.append(num)

    return List_of_prime_factors

def amount_of_primes(size, i = 2): #i is 2 since 2 is the smallest prime number possible

    List_of_primes = [] #initializing the list of primes

    while len(List_of_primes) < size: #will keep looping till there are as many values in the list as indicated by size

        if is_prime(i) == True: #checking wether i is a prime number
            List_of_primes.append(i) #adds the number in the list
        
        i += 1 #increments i

    return List_of_primes
         
def menu(option = 0): 

    while(option != 5): #loops until exit is chosen

        option = int(input("\n1. Check if number is prime\n2. Find all prime factors of a number\n3. Find every prime number up to ...\n4. Find a given number of primes\n5. Exit..\n"))   

        if option == 1: #if 1 is entered the following code is to be executed

            number = input("Enter number you want to check if is prime ")
            number = is_int(number) #checks if the number entered is an integer
            print(is_prime(number))

        if option == 2: #if 2 is entered the following code is to be executed
            number = input("Enter number you want to find its prime factors ")
            number = is_int(number) #checks if the number entered is an integer
            print(find_all_prime_factors(number))

        if option == 3: #if 3 is entered the following code is to be executed
            number = input("Enter number you want to find the prime numbers up to ")
            number = is_int(number) #checks if the number entered is an integer
            print(all_primes_up_to(number))
    
        if option == 4: #if 4 is entered the following code is to be executed
            number = input("Enter how many prime numbers do you want ")
            number = is_int(number) #checks if the number entered is an integer
            print(amount_of_primes(number))

        if option == 5:
            print("Exiting...") #exists the loop

def is_int(num): #function to check if an entered number is an integer

    while isinstance(num, int) == False: #checks if num is not an integer

        try: #tries to run the followiung code
               num = int(num)

        except ValueError:    #if the error ValueError is shown, then the number is not an integer
                print("The value you entered is not an integer, Please enter a valid integer")
                num = input()
    return num



menu() #executes the menu function
