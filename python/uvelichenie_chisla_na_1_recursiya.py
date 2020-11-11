def reverse(num):
    if num == 0:
        print()
        return
    digit = (num % 10 + 1) % 10
    rest = num // 10
    return digit
    reverse(rest)
    
       
n = int(input("> "))
print(reverse(n))