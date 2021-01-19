s = input("Введите строку: ")
c = input("Введите символ: ")[0]
index = 0
k = True
for i in range(len(s)):
    if c == s[i]:
        index = i
        k = False
        break
if k:
    print("Такого символа нету")
else:
    print(f"индекс вашего символа {index}")