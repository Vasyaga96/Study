n = int(input("Введите число "))

for i in range(n // 2, 0, -1):
    print("*", end="")
    for j in range(i):
        if n % 2 == 0 and i == 1:
            print(end="")
        else:
            print(end=" ") 
    print("*")
if n % 2 == 1:
    print("**")
for i in range(1, (n // 2) + 1, +1):
    print("*", end="")
    for j in range(i):
        if n % 2 == 0 and i == 1:
            print(end="")
        else:
            print(end=" ")
    print("*")