n = int(input("Введите целое число: "))
ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
tens = ["", "", "twenty", "thirty", "fourty", "fivety", "sixty", "seventy", "eighty", "ninety"]
teens = ["ten", "eleven", "twelwe", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen"]
hundred = "hundred"
orders = ["", "thousand", "million", "billion"]
three = n % 1000
one_result = three % 10
teens_result = three % 100 // 10
tens_result = three // 100
one_str = ones[one_result] + " "
teens_str = teens[teens_result] + " "
tens_str = ones[tens_result] + " " + hundred + " "
numbers = tens_str + teens_str + one_str + " "
print(numbers)
