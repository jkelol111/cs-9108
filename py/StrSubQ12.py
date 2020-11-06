string = str(input("Input string: "))
string_mod = ""
for char in string:
    if char.isupper():
        string_mod += char.lower()
    elif char.islower():
        string_mod += char.upper()
    else:
        string_mod += char
print(string_mod)