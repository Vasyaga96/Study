def fuc(x):
    k = 1
    for i in range (1, x + 1):
        k *= i
    return k

def recursion_fuc(x):
    if x == 1 or x == 2:
        return 1
    return fac(n - 1) * n

n = int(input("Введите число: "))
print(fuc(n))
print(recursion_fuc(n))