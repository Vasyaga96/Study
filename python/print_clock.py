def print_line(x):
    for i in range(x):
        print("*", end="")
    print()

def print_clock(x):
    for i in range(x, 0, -2):
        for l in range((x - i) // 2):
            print(end=" ")
        print_line(i)
    for i in range(1, x + 1, 2):
        for l in range((x - i) // 2):
            print(end=" ")
        print_line(i)

print_clock(5)


# for i in range(n, 0, -2):
#     k = (n - i) // 2
#     for l in range(k):
#             print(end=" ")
#     for j in range (i): 
#         print("*", end="")
#     print()

# for i in range(1, n + 1, 2):
#     k = (n - i) // 2
#     for l in range(k):
#             print(end=" ")
#     for j in range(i):
#         print("*", end="")
#     print()