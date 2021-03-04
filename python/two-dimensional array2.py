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
sum_prev = 0
sum_current = 0
sort = True
points = []
command = []
for i in range(len(arr)):
  command.append(i + 1)
  sum_current = 0
  for j in range(len(arr[i])):
    sum_current += arr[i][j]
  points.append(sum_current)
while sort:
  sort = False
  for i in range(len(arr) - 1):
    if points[i] < points[i + 1]:
      points[i], points[i + 1] = points[i + 1], points[i]
      command[i], command[i + 1] = command[i + 1], command[i]
      sort = True
print("----------------------------")
for i in range(len(arr)):
  print(f"{i + 1} {command[i]} {points[i]}")
