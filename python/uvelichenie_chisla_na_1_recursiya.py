def reverse(num):
    if num == 0:
        if num == 0:
            print()
            return
        digit = num % 10
        print(digit, end="")
        rest = num // 10
        reverse(rest)
    digit = num % 10 + 1
    rest = num // 10
    reverse(rest)   

print(reverse(123))
    
    