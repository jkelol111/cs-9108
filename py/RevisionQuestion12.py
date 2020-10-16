number_range = int(input("Input number: "))

print("Table")
print("-----")
for number in range(1, number_range + 1):
    for times in range(1, 10):
        print("{0} x {1} = {2}".format(number, times, (number * times)))
    print("-----")
