year = int(input("Введите номер года: "))

if (year % 4 == 0) and (year % 100 != 0) or (year % 400 == 0):
    print("Этот год високосный")
else:
    print("Этот год невисокосный")