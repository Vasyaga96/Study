n = int(input("Введите число "))

if n % 2 == 0:
    k = (n // 2) - 1
else:
    k = n // 2 
for i in range(k, 0, -1):
    print("*", end="")
    for j in range(i):
        print(end=" ") 
    print("*")
if n % 2 == 0:
    print("**")
for i in range(0, k + 1, +1):
    print("*", end="")
    for j in range(i):
        print(end=" ")
    print("*")