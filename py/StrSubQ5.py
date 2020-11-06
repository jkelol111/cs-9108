string = ''.join(reversed(str(input("Input string: "))))
print(string)
for i in range(0, 3):
    print(string[i], end=" ")