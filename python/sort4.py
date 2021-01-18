import random
arr = []
index = 0
z = 0
n = int(input("Введите целое положительное число: "))
for i in range(n):
    arr.append(random.randint(1, 10))
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
arr = sorted(arr, reverse=True)
print('__________')
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")