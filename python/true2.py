soso = True
bad = True
art = []
for i in range(5):
    art.append(int(input("Введите оценку: ")))
for i in range(len(art)):
    print(f"{i}, {art[i]}")
for i in range(len(art)):
    if art[i] == 5:
        soso = False
    elif art[i] < 3:
        bad = False
if soso:
    print("обычный")
elif not bad:
    print("двоечник")
else:
    print("отличник")

