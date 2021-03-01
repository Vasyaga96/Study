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
sum_arr = []
index = []
for i in range(len(arr)):
    index.append(i + 1)
    sum_cur = 0
    for j in range(len(arr[i])):
        sum_cur += arr[i][j]
    sum_arr.append(sum_cur)
while sort:
    sort = False
    for i in range(len(arr) - 1):
        if sum_arr[i] < sum_arr[i + 1]:
            sum_arr[i], sum_arr[i + 1] = sum_arr[i + 1], sum_arr[i]
            index[i], index[i + 1] = index[i + 1], index[i]
print(sum_arr)
print(index)

