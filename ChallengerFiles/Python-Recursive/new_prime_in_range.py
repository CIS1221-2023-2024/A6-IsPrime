''' Aim: This file was put up to create a new feature in the program that allows you to find the prime numbers
      between a given range.
 Capabilities: It is difficult to determine the exact scope of the inputs but an observation is that it cannot handle ranges larger than 1000
 Conclusion: I added this function to the main file '''

def print_primes_in_range(start, end):
    if start <= end:
        if isPrime(start):
            print(start)
        print_primes_in_range(start + 1, end)
        # checks if prime for start then increments until end is reached
    else: 
        print('Limits are incorrect') #ERROR this line is printed with every execution
        
        
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

# Example usage:
lower_limit = int(input("Enter the lower limit: "))
upper_limit = int(input("Enter the upper limit: "))

print(f"Prime numbers between {lower_limit} and {upper_limit}:")
print_primes_in_range(lower_limit, upper_limit)