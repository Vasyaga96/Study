arr = []
n = int(input("Введите значение для массива arr: "))
arr.append(n)
num = 1
composition = 1
while n != 0:
    n = int(input("Введите значение для массива arr: "))
    arr.append(n)
    num += 1
arr.remove(0)
num -=1
print(f"Ваш массив {arr}")
for i in range(num):
    print(f"индекс {i} значение {arr[i]}")
for i in range(num):
    composition *= arr[i]
print(f"Произведение всех значений массива arr {composition}")
