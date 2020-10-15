uid = input("Input User ID: ")

if len(uid) == 6:
    if uid[0].isupper() and (uid[1].islower() and uid[2].islower()) and (uid[3].isdigit() and uid[4].isdigit() and uid[5].isdigit()):
        print("Correct Format")
    else:
        print("Wrong Format")
else:
    print("Wrong Format")
