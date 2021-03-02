import random
x = random.randint(0, 100)
num = 0
n = int(input("Введите целое положительное число: "))
if x > n:
        print("Мое число больше")
        num += 1
elif x < n:
    print("Мое число меньше")
    num += 1
else:
    num += 1
    print(f"Вы угадали за {num} попыток")
while x != n:
    n = int(input("Введите целое положительное число: "))
    if x > n:
        print("Мое число больше")
        num += 1
    elif x < n:
        print("Мое число меньше")
        num += 1
    else:
        num += 1
        print(f"Вы угадали за {num} попыток")