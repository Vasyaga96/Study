def fuc(x):
    k = 1
    for i in range (1, x + 1):
        k *= i
    return k

def recursion_fuc(x):
    if x == 0 or x == 1:
        return 1
    return fuc(x - 1) * x

n = int(input("Введите число: "))
print(fuc(n))
print(recursion_fuc(n))