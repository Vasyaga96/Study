import random
arr = []
Temper = False
for i in range(31):
    x = random.randint(-5, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}")
for i in range(len(arr)):
    if arr[i] < 0:
        Temper = True
        break
if lozh:
    print("Отрицательныe температуры есть")
else:
    print("Отрицательных температур нет")