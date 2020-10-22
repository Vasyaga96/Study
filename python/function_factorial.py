def factorial(x):
    k = 1
    for i in range (1, x + 1) :
        k *= i
        return k

n = int(input("Введите число n: "))
m = int(input("Введите число m: "))

difference = n - m

answer = factorial(n) // (factorial(difference) * factorial(m))
print(answer)

# def factorial_m():
#     k = 1
#     for i in range (1, m + 1):
#         k *= i

# difference = n - m

# def factorial_difference():
#     k = 1
#     for i in range (1, difference + 1):
#         k *= i

# answer = factorial_n // factorial_difference * factorial_m

# print(answer)