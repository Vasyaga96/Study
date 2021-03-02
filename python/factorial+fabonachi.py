m = int(input("Введите число m: "))
n = int(input("Введите число n: "))
difference = n - m
fuc_difference = 1
for i in range (1, difference + 1):
    fuc_difference *= i
fuc_n = 1
for i in range (1, n + 1):
    fuc_n *= i
fuc_m = 1
for i in range (1, m + 1):
    fuc_m *= i
end_difference = fuc_n // (fuc_m * fuc_m)

print(end_difference)