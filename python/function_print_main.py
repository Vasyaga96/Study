def print_line(x):
    for i in range(x):
        print("*", end="")
    print()

def print_clock(x):
    for i in range(x, 0, -2):
        for l in range((x - i) // 2):
            print(end=" ")
        print_line(i)
    for i in range(3, x + 1, 2):
        for l in range((x - i) // 2):
            print(end=" ")
        print_line(i)

def print_main(x):
    for i in range(x, 0, -2):
        print_clock(i)

print_main(5)