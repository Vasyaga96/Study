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
    if two == one:
        return 1    
    else:
        return 0
answer = ticket(123324)
if answer == 1:
    print("Билет счастливый")
else:
    print("Билет обычный")