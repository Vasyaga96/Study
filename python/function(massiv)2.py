arr = [3,5,6]
def mas(x,y):
    otvet = 0
    k = True
    for i in range(len(x)):
        if x[i] == y:
            otvet = i
            k = False
            return otvet
    if k:
        return -1
n = int(input("Введите число: "))
print(mas(arr, n))