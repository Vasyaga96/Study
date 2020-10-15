n = int(input("Введите число "))
for i in range (n):
    for j in range(n):
        if (j < i and j < n - (i + 1)) or (j > i and j > n - (i + 1)):
            print(".", end="")
        else:
            print("*", end="")
    print()