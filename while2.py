n = int(input("Введите число "))

sum = 0

while n > 0:
    ostatok = n % 10
    sum = sum + ostatok
    n = n // 10
print(f"сумма всех числел {sum}")