import random
arr = []
lozh = False
for i in range(31):
    x = random.randint(-5, 10)
for i in range(len(arr)):
    print(f"{i}, {arr[i]}", end="")
for i in range(len(arr)):
    if arr[i] < 0:
        print("Да, отрицательные температуры были")
        break
    else:
        print("Нет, отрицательных температур не было")