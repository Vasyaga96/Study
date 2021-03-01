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
sum_cur = 0
sort = True
while sort:
  sort = False
  for i in range(len(arr)):
    sum_prev = sum_cur
    sum_cur = 0 
    for j in range(len(arr[i])):
      sum_cur += arr[i][j]
    if sum_prev < sum_cur:
      arr[i], arr[i - 1] = arr[i - 1], arr[i]
      sort = True
    sum_cur = sum_prev
print(arr)