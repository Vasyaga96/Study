arr = [4,5,1,3,6,8,4,5]
def sortirovka(x,y):
    index = 0
    if y == True:
        for i in range(len(x) - 1):
            index = i
            for j in range(i, len(x)):
                if x[index] > x[j]:
                    index = j
            x[i], x[index] = x[index], x[i]
    if y == False:
        for i in range(len(x) - 1):
            index = i
            for j in range(i, len(x)):
                if x[index] < x[j]:
                    index = j
            x[i], x[index] = x[index], x[i]
    return x
print(sortirovka(arr, False))
print(sortirovka(arr, True))