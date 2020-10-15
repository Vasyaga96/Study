n = int(input("Введите целое положительное число "))

for i in range(n, 0, -2):
    k = (n - i) // 2
    for l in range(k):
            print(end=" ")
    for j in range (i): 
        print("*", end="")
    print()

for i in range(1, n + 1, 2):
    k = (n - i) // 2
    for l in range(k):
            print(end=" ")
    for j in range(i):
        print("*", end="")
    print()