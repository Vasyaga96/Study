import random
k = False
otvet = 0
arr = []
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(0, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
z = int(input("Введите целое положительное число: "))
for i in range(len(arr)):
    if arr[i] == z:
        k = True
        otvet = i
        break
if k == False:
    print("Такого числа нет")
else:
    print(f"Ваш индекс {otvet}")
    
