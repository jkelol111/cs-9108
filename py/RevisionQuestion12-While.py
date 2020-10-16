number_range = int(input("Input number: "))

print("Table")
print("-----")
number_count = 1
times_count = 1

while number_count <= number_range:
    times_count = 0
    while times_count <= 10:
            print("{0} x {1} = {2}".format(number_count, times_count, (number_count * times_count)))
            times_count += 1
    number_count += 1
    print("-----")
