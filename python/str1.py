s = input("Введите строку ")
# k = ""
# for i in range(len(s) - 1, -1, -1):
#     k = k + s[i]
# if s == k:
#     print("палиндром")
i = 0
j = len(s) - 1
k = True
while i < j:
    while s[j] == " ":    
        j -= 1
    while s[i] == " ":
        i += 1
    if s[j] != s[i]:
        k = False
        break
    i += 1
    j -= 1

if k:
    print("палиндром")
else:
    print("не палендром")

