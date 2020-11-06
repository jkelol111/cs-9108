msg = str(input("Input message: "))
cmd = int(input("Select operation (0: encrypt, 1: decrypt): "))
msg_encrypted = ""

if cmd == 0:
    for char in msg:
        msg_encrypted += chr(ord(char) + 5)
    print(msg_encrypted)
elif cmd == 1:
    for char in msg:
        msg_encrypted += chr(ord(char) - 5)
    print(msg_encrypted)
else:
    print("Invalid command!")