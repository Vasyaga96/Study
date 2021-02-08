n = int(input("Введите целое число: "))
ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
teens = ["ten", "eleven", "twelwe", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen"]
tens = ["", "", "twenty", "thirty", "fourty", "fivety", "sixty", "seventy", "eighty", "ninety"]
hundred = "hundred"
orders = ["", "thousand", "million", "billion"]
result = ""
num_three = 0
sign = True
if n == 0:
    result = "zero"
elif n < 0:
    n *= -1
    sign = False
while n > 0:
    three = n % 1000
    one = three % 10
    ten = three % 100 // 10
    hund = three // 100
    if ten != 1 and hund >= 1 and ten != 0:
        three_result = ones[hund] + " " + hundred + " " + tens[ten] + " " + ones[one]
    elif ten == 0 and hund >= 1 and one > 0:
        three_result = ones[hund] + " " + hundred + " " + ones[one]
    elif ten != 1 and hund >= 1 and ten == 0 and one < 0:
        three_result = ones[hund] + " " + hundred + " " + ones[one]
    elif ten != 1 and hund >= 1 and ten == 0 and one == 0:
        three_result = ones[hund] + " " + hundred
    elif ten != 1 and hund < 1 and three > 9:
        three_result = tens[ten] + " " + ones[one]
    elif ten == 1 and hund < 1:
        three_result = teens[one]
    elif ten == 0 and hund == 0:
        three_result = ones[one]
    else:
        three_result = ones[hund] + " " + hundred + " " + teens[one]
    if three == 0:
        result = three_result + result
    elif num_three == 0:
        result = three_result
    else:
        result = three_result + " " + orders[num_three] + " " + result
    num_three += 1
    n = n // 1000
if not sign:
    result = "minus" + " " + result
print(result)
