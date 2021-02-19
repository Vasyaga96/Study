import random
arr = []
k = 0
sort = True
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(1, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
while sort:
    sort = False
    for j in range(len(arr) - 1):
        if arr[j] > arr[j + 1]:
            arr[j], arr[j + 1] = arr[j + 1], arr[j]
            sort = True
print("--------------")
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
