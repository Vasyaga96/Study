def print_line(x):
    for i in range(x):
        print("*", end="")
    print()

def print_clock(x, y):
    for i in range(x, 0, -2):
        for l in range(((x - i) // 2) + y):
            print(end=" ")
        print_line(i)
    for i in range(3, x + 1, 2):
        for l in range(((x - i) // 2) + y):
            print(end=" ")
        print_line(i)

def print_main(x):
    y = 0
    for i in range(x, 0, -2):
        y = y + 1  
        print_clock(i, y)
    for i in range(3, x + 1, 2):
        y = y - 1  
        print_clock(i, y)
print_main(5)