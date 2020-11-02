number_one = int(input("Введите первое число: "))
number_two = int(input("Введите второе число: "))
number_three = int(input("Введите третье число: "))

if number_one > number_two and number_one > number_three:
    greatest = number_one
elif number_two > number_one and number_two > number_three:
    greatest = number_two
else:
    greatest = number_three

if number_one < number_two and number_one < number_three:
    fewest = number_one
elif number_two < number_one and number_two < number_three:
    fewest = number_two
else:
    fewest = number_three

difference = greatest - fewest
