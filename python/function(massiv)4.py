arr = [4,5,6]
def min(x):
    index = 0
    for i in range(len(x)):
        if arr[index] > x[i]:
            index = i
    return index
print(min(arr))