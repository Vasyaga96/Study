import random
k = 0
otvet = 0
arr = []
n = int(input("Введите целое положительное число: "))
for i in range(n):
    x = random.randint(-10, 10)
    arr.append(x)
for i in range(len(arr)):
    print(f"{i}. {arr[i]}")
k = arr[0] # занесли в к первое значение массива что бы с него начать
for i in range(len(arr)): #цикл повторяется количество индексов раз
    if k < arr[i]: #если первое значение больше индекса который сейчас в цикле то
        k = arr[i] #то мы приравниваем к к нему
if arr[i] == k: #если  значение равно k то
    otvet = i #заносим в otvet номер цикла     
print(f"Ваш индекс {otvet} ваше значение {k}") #выводим индекс и значение
