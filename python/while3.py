n = int(input("Введите число: "))

sum = 0

while n > 999:
    k = n % 10
    sum = k + sum
    n = n // 10

sum2 = 0
while n > 0:
    k = n % 10
    sum2 = k + sum2
    n = n // 10

if sum == sum2:
    print("Билет счастливый")
else:
    print("Билет обычный")