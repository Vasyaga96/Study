import random
# k = 0 #наибольшее значение
otvet = 0 #индекс
arr = []
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(-10, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
for i in range(len(arr)): #цикл повторяется количество индексов раз
    if arr[otvet] < arr[i]: #если первое значение больше индекса который сейчас в цикле то
        otvet = i
print(f"Ваш индекс {otvet} ваше значение {arr[otvet]}") #выводим индекс и значение
