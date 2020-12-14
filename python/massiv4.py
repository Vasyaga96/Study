import random
index = 0 #индекс
arr = []
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(-10, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
for i in range(len(arr)): #цикл повторяется количество индексов раз
    if arr[index] < arr[i]: #если первое значение больше индекса который сейчас в цикле то
        index = i #присовили переменной ответ i который сейчас есть и это и есть индекс у которого наибольшее значение
print(f"Ваш индекс {otvet} ваше значение {arr[index]}") #выводим индекс и значение
