raw = open("raw.txt", "r").read().split("\n")
out = ""
for char in raw:
    out +=  '"' + char + '",'
print(out) 