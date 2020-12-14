excelent = True
usual = True
art = []
for i in range(5):
    art.append(int(input("Введите оценку: ")))
for i in range(len(art)):
    print(f"{i}, {art[i]}")
for i in range(len(art)):
    if art[i] < 5:
        excelent = False
    if art[i] < 3:
        usual = False
        break
if excelent:
    print("Отличник")
elif usual:
    print("Обычный")
else:
    print("Двоечник")