number_range = int(input("Input number: "))

print("Table")
print("-----")
for number in range(1, number_range + 1):
    for times in range(1, 11):
        print("{0} x {1} = {2}".format(number, times, (number * times)))
    print("-----")


# range(1, 10) => [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
