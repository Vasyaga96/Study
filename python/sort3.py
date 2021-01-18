import random
arr = []
index = 0
z = 0
n = int(input("Введите целое положительное число: "))
for i in range(n):
    arr.append(random.randint(1, 10))
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
for i in range(1, len(arr)):
    index = i
    while index > 0 and arr[index] < arr[index - 1]:
        arr[index - 1], arr[index] = arr[index], arr[index - 1]
        index = index - 1
print("________")
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")