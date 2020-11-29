n = int(input("Введите число индексов: "))
arr = []
sum = 0
for i in range(n):
    z = int(input(f"Введите значение для массива в индекс  {i}: "))
    arr.append(z)
print()
print(f"Ваш массив {arr}")

for i in range(n):
    print(i, arr[i])
    
for i in range(n):    
    sum = arr[i] + sum
print()
print(f"Сумма значений вашего массива {sum}")
