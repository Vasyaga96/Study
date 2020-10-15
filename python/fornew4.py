n = int(input("Введите размер квадрата: "))
for i in range(n):
    for j in range(n):
        if j >= i: 
            print("*", end="")
        else:
            print(".", end="")
    print() 