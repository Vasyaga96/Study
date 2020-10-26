def sum(x):
    summ = 0
    while x > 0:
        k = x % 10
        summ = k + summ
        x = x // 10
        return summ

def ticket(x):
    while x > 999:
        two = sum(x)
    while x > 0:
        one = sum(x)
    if one == two:
        return print("Билет счастливый")
    else:
        return print("Билет не счастливый")
ticket(123321)