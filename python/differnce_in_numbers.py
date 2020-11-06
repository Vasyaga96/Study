def greatest(x, y, z):
    if x > y and x > z:
        greatest = x
    elif y > x and y > z:
        greatest = y
    else:
        greatest = z
    return greatest

def fewest(x, y, z):
    if x < y and x < z:
        fewest = x
    elif y < x and y < z:
        fewest = y
    else:
        fewest = z
    return fewest

number_one = int(input("Введите первое число: "))
number_two = int(input("Введите второе число: "))
number_three = int(input("Введите третье число: "))

difference = greatest(number_one, number_two, number_three) - fewest(number_one, number_two, number_three)
print(difference)

print(difference)