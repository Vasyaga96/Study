arr = [4,5,6]
def max(x):
    index = 0
    for i in range(len(x)):
        if arr[index] < x[i]:
            index = i
    return index
print(max(arr))
