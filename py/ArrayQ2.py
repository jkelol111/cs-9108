numbers = []
store = 0.0

while store != "stop":
    numbers.append(store)
    store = str(input("Input a number: "))

total = 0.0
for number in numbers:
    total += float(number)

average = total / float(len(numbers))

print("The average of all the numbers is: " + str(average))