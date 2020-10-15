m = int(input("Введите число m: "))
n = int(input("Введите число n: "))

raznost = n - m

r = 1

for i in range (1, raznost + 1):
    r *= i

zn = 1

for i in range (1, n + 1):
    zn *= i

km = 1

for i in range (1, m + 1):
    km *= i

proizvedenie = zn // (r * km)

print(proizvedenie)