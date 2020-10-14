num = int(input("Введите целое положительное число "))

for i in range(num, 0, -2):
    if i == 3:
        print(end=" ")
    elif i == 1:
        print(end="  ")
    for j in range (i):
        print("*", end="")
    print()
for i in range(3, num + 1, 2):
    if i == 3:
        print(end=" ")
    for j in range(i):
        print("*", end="")
    print()