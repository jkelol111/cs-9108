hours = float(input("Input weekly hours: "))
wage = float(input("Input hourly wage: "))

gross = 0
net = 0

if hours > 40:
	gross = (40 * wage) + (1.5 * wage * (hours - 40))
else:
	gross = hours * wage

if gross > 100:
	net = gross - 25
else:
	net = gross

print("")
print(f"Gross pay: ${gross}")
print(f"Net pay: ${net}")