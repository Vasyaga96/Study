import random
arr = []
z = 0
n = int(input("Введите целое положительное число: "))
for i in range(n):
    arr.append(random.randint(1, 10))
arr = sorted(arr, reverse=True)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
k = int(input("Введите целое положительное число: "))
z = n // 2
while arr[z] > k or arr[z] < k:
    z = n // 2
    z = z // 2
if arr[z] == k:
    print(f"ваш индекс {z}")
    








# for i in range(len(arr)):
#     if arr[i] == k:
#         z = True
#         otvet = i
#         break
# if z == False:
#     print("Такого числа нет")
# else:
#     print(f"Ваш индекс {otvet}")