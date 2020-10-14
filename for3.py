# n = int(input("Введите число "))
# for i in range(1, n + 1):
#     if i == n:
#         print(f"{i}. ", end="")
#     else:
#         print(f"{i}, ", end="")

n = int(input("Введите число "))
for i in range(1, n):
    print(f"{i}, ", end="")

print(f"{n}.")