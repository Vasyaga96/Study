arr = [3,5,6]
def find(x,y):
    otvet = 0
    for i in range(len(x)):
        if x[i] == y:
            otvet = i
            return otvet
        return -1
n = int(input("Введите число: "))
print(find(arr, n))