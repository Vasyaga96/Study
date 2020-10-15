n = int(input("Введите число: "))

sum = 0

while n > 0:
    k = n % 10
    sum = k + sum
    n = n // 10
print(f"Сумма цифр вашего числа {sum}")