import random
otvet = 0
arr = []
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(0, 10)
    arr.append(x)
print(arr)
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
z = int(input("Введите целое положительное число: "))
for i in range(len(arr)):
    if arr[i] == z:
        otvet = i
        print(f"Номер {otvet}")
    else:
        print("такого числа нет")
