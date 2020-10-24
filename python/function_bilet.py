def sum(x):
    k = 0
    sum = 0
    sum = k + sum
    x = x // 10

def ticket(x):
    while x > 999:
        k = x % 10
        sum(x)
    while x > 0:
        k = x % 10
        sum(x)

ticket(123321)