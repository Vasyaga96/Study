import random
arr = []
start = 0
center = 0
end = 0
found = True
n = int(input("Введите целое положительное число: "))
for i in range(n):
    arr.append(random.randint(1, 10))
arr = sorted(arr)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
k = int(input("Введите целое положительное число: "))
end = n - 1
center = (start + end) // 2
while arr[center] != k:
    if start >= end:
        found = False
        break
    if arr[center] < k:
       start = center + 1      
    elif arr[center] > k:
       end = center - 1 
    center = (start + end) // 2
if found:
    print(f"ваше число {center}")
else:
    print("Такого числа нету")