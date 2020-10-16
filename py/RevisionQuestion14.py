sum = 0
some_int = int(input("Input a positive integer (negative integer to quit): "))

while some_int >= 0:
    sum += some_int

    some_int = int(input("Input a positive integer (negative integer to quit): "))

print("The sum is: {0}".format(sum))
