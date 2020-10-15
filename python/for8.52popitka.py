n = int(input("Введите число "))

for i in range(n // 2, 0, -1):
    print("*", end="")
    for j in range(i):
        if i == 1 and n % 2 == 0:
            print(end="")
        else:
           print(end=" ") 
    print("*")
for i in range(0, n // 2, +1):
    print("*", end="")
    for j in range(i):
        if i == 0:
            print(end="")
        else:
            print(end=" ")
    print("*")