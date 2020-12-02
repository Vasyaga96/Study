arr = []
n = int(input("Введите значение для массива arr: "))
product = 1
while n != 0:
    arr.append(n)
    n = int(input("Введите значение для массива arr: "))
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
for i in range(len(arr)):
    product *= arr[i]
print(f"Произведение всех значений массива arr {composition}")