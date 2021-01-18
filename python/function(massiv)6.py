arr = [3,4,7,5]
def pol (x,y):
    start = 0
    center = 0
    end = 0
    found = True
    x = sorted(x)
    end = len(x) - 1
    center = (start + end) // 2
    while arr[center] != y:
        if start >= end:
            found = False
            break
        if x[center] < y:
            start = center + 1      
        elif x[center] > y:
            end = center - 1 
        center = (start + end) // 2
    return center
print(pol(arr, 5))