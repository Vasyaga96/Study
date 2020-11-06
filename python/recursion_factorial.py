def fuc(x):
    k = 1
    for i in range (1, n + 1):
        k *= i
    return k

def recursion_fuc(x):
    fuc(1) = 1
    fuc(2) = 1
    return fac(n - 1) * n

n = int(input("Введите число: "))
print(f"Факториал вашего числа + {recursion_fuc(n)}")