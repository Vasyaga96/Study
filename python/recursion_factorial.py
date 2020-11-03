n = int(input("Введите число: "))

def rec_fac(x):
    if x == 1 or x == 2:
        return 1
    return rec_fac(x // 1) * rec_fac(x // 2)

rec_fac(n)