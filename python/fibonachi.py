n = int(input("Введите целое положительное число: "))

n1 = 1
n2 = 1
k = 1

for i in range(3, n + 1):
    k = n2 + n1
    n1 = n2
    n2 = k
print(k)