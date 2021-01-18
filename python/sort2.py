import random
arr = []
index = 0
n = int(input("введите целое положительное число: "))
for i in range(n):
    arr.append(random.randint(1, 10))
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
for i in range(len(arr) - 1):
    index = i
    for j in range(i, len(arr)):
        if arr[index] > arr[j]:
            index = j
    arr[i], arr[index] = arr[index], arr[i]
print("---------------")
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
