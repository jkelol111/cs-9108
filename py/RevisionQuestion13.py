def get_price_quantity():
    price = float(input("Input price (input 0 to quit): "))
    quantity = int(input("Input quantity (input 0 to quit): "))
    return (price, quantity)


sum = 0.0

price_quantity = get_price_quantity()

while price_quantity[0] > 0.0 and price_quantity[1] > 0:
    sum += price_quantity[0] * price_quantity[1]

    price_quantity = get_price_quantity()

print("Total sum to be paid: ${0}".format(sum))
