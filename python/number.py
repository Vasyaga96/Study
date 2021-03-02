a = int(input("Введите число a: "))
b = int(input("Введите число b которое больше a: "))
c = int(input("Введите число c: "))
if c < a:
    print("Ваше число меньше a")
elif c > b:
    print("Ваше число больше b")
elif c == a:
    print("Ваше число равно a")
elif c == b:
    print("Ваше число равно b")
else:
    print("Ваше число между a и b")