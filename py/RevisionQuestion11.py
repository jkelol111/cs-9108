number = int(input("Input number: "))

print("Table")
print("-----")
for times in range(1, 10):
    print("{0} x {1} = {2}".format(number, times, (number * times)))
