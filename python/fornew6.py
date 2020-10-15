n = int(input("Введите размер квадрата: "))
for i in range(n):
    for j in range(n):
        if j >= n - (i + 1): 
            print("*", end="")
        elif i <= n // 2:
            print(".", end="")
    print()