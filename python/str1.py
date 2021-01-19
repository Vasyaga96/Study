s = input("Введите строку ")
k = ""
for i in range(len(s), 0, -1):
    k = k + s[i]
if s == k:
    print("палиндром")

