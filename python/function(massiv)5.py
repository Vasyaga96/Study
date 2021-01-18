arr = [4,5,1,3]
def sortirovka (x,y):
    x = sorted(x, reverse=y)
    return x
print(sortirovka(arr, False))
print(sortirovka(arr, True))