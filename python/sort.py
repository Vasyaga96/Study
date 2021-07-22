import random
arr = []
sort = True
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(1, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
while sort:
    sort = False
    for i in range(len(arr) - 1):
        if arr[i] > arr[i + 1]:
            arr[i], arr[i + 1] = arr[i + 1], arr[i]
            sort = True
print("--------------")
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
