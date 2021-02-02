n = int(input("Введите целое число: "))
ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
teens = ["ten", "eleven", "twelwe", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen"]
tens = ["", "", "twenty", "thirty", "fourty", "fivety", "sixty", "seventy", "eighty", "ninety"]
hundred = "hundred"
orders = ["", "thousand", "million", "billion"]
result = ""
num_three = 0
while n > 0:
    three = n % 1000
    one = three % 10
    ten = three % 100 // 10
    hund = three // 100
    if ten != 1 and n >= 100:
        three_result = ones[hund] + " " + hundred + " " + tens[ten] + " " + ones[one]
    elif ten != 1 and n < 100:
        three_result = ones[hund] + " " + tens[ten] + " " + ones[one]
    else:
        three_result = ones[hund] + " " + hundred + " " + teens[one]
    result = three_result + " " + orders[num_three] + " " + result
    num_three += 1
    n = n // 1000
print(result)
