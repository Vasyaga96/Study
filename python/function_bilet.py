def sum(x):
    summ = 0
    while x > 0:
        k = x % 10
        summ = k + summ
        x = x // 10
    return summ

def ticket(x):
    two = x % 1000
    two = sum(two)
    one = x // 1000
    one = sum(one)
    return two == one

n = int(input("Введите номер билета: "))
ticket(n)
if ticket(n):
    print("Билет счастливый")
else:
    print("Билет обычный")