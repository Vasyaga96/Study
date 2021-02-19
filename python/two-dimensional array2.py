import random
n = int(input("Введите колличество комманд: "))
m = int(input("Введите колличество соревнований: "))
arr = []
for i in range(n): # количество строк
  row = []
  for j in range(m): # количество столбцов
    row.append(random.randint(0, 10))
  arr.append(row)
for i in range(len(arr)):
    for j in range(len(arr[i])):
        print(f"{arr[i][j]} ", end="")
    print()
Max = 0
a = 0
for i in range(len(arr) - 1):
  index = i
  for j in range(i, len(arr)):
    for z in range(len(arr)):
        a = 0
        for k in range(len(arr[i])):
            a += arr[i][j]
        if Max < a:
            Max = a
            command = i + 1
        if Max < a:
          arr[i], arr[k] = arr[k], arr[i]
print(arr)