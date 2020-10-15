n = int(input("Введите целое положительное число "))

for i in range(1, n, 2):
    print("*", end="")
    for j in range((n - i) // 2): 
        print(" ", end="")
    print("*")
for i in range(n, 0, -2):
    print("*", end="")
    for j in range((n - i) // 2): 
        print(" ", end="")
    print("*")