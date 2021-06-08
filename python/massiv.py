n = int(input("Введите число индексов: "))
arr = []
sum = 0
for i in range(n):
    z = int(input(f"Введите значение для массива в индекс  {i}: "))
    arr.append(z)
for i in range(n):
    print(f"{i}. {arr[i]}")
for i in range(n):    
    sum = arr[i] + sum
print(f"Сумма значений вашего массива {sum}")