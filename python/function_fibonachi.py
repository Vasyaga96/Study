def fibonachi(x):
    n1 = 1
    n2 = 1
    k = 1
    for i in range(3, x + 1):
        k = n2 + n1
        n1 = n2
        n2 = k
    return n2

n = int(input("Введите число: "))
print(fibonachi(n))