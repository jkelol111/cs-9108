raw = open("raw.txt", "r").read()
out = ""
for char in raw:
    out +=  '"' + char + '",'
print(out) 