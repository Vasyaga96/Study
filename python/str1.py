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
    if s[j] != s[i]:
        False
    i += 1
    j -= 1
if k:
    print("палиндром")
else:
    print("не палендром")

