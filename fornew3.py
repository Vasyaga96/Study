n = int(input("Введите размер квадрата: "))
for i in range(n):
    for j in range(n):
        if i == j or j == n - (i + 1): 
            print("*", end="")
        else:
            print(".", end="")
    print()

#n = int(input("Введите размер квадрата: "))
# for i in range(n, 0, -1):
#     for j in range(0, n):
#         if i == j + 1:
#             print("*", end="")
#         else:
#             print(".", end="")
#     print()