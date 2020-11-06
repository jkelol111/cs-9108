string = str(input("Input string with *: "))
string_stripped = string.replace("*", "")
# Inefficient but laxy thinking way:
#
# string_stripped = ""
# for char in string:
#     if char != "*":
#         string_stripped += char
print(string_stripped)