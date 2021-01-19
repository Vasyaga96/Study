s = input("Введите строку ")
k = ""
for i in range(len(s) - 1, -1, -1):
    k = k + s[i]
if s == k:
    print("палиндром")

