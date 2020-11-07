# def reverse(num):
#     if num == 0:
#         print()
#         return
#     digit = num % 10 # 123 -> 3
#     print(digit, end="")
#     rest = num // 10 # 123 -> 12
#     reverse(rest)

def reverse(num):
    if num == 0:
        print()
        return
    print(num % 10, end="")
    reverse(num // 10)

x = int(input("> "))
reverse(x)