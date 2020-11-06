string = str(input("Input a string with the letter 'a': "))
char_loop = 0
for char in string:
    if char == "a":
        print(char_loop)
    char_loop += 1