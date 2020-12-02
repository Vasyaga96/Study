import random
k = 0
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
        k += 1
        otvet = i

if k == 0:
    print("Такого числа нет")
else:
    print(f"Ваш ответ {otvet}")
        

