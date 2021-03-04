field = [
  [" ", " ", " "],
  [" ", " ", " "],
  [" ", " ", " "]
]
game = True
step = 0
for i in range(len(field)):
    print("+-+-+-+")
    print(f"|{field[i][0]}|{field[i][1]}|{field[i][2]}|")
print("+-+-+-+")
print("-------------------------------")
while game:
    print("Ходит игрок x")
    line_number = int(input("Введите номер строки от 1 до 3: "))
    column_number = int(input("Введите номер столбца от 1 до 3: "))
    while line_number < 0 or line_number > 3 or column_number < 0 or column_number > 3:
        line_number = int(input("Введите номер строки от 1 до 3: "))
        column_number = int(input("Введите номер столбца от 1 до 3: "))
    while field[line_number - 1][column_number - 1] == "x" or field[line_number - 1][column_number - 1] == "0":
        print("Это место занято. Ходит игрок x")
        line_number = int(input("Введите номер строки от 1 до 3: "))
        column_number = int(input("Введите номер столбца от 1 до 3: "))
    field[line_number - 1][column_number - 1] = "x"
    step += 1
    for i in range(len(field)):
        print("+-+-+-+")
        print(f"|{field[i][0]}|{field[i][1]}|{field[i][2]}|")
    print("+-+-+-+")
    print("-------------------------------")
    if (field[0][0] == "x" and field[0][1] == "x" and field[0][2] == "x") or (field[1][0] == "x" and field[1][1] == "x" and field[1][2] == "x") or (field[2][0] == "x" and field[2][1] == "x" and field[2][2] == "x") or (field[0][0] == "x" and field[1][0] == "x" and field[2][0] == "x") or (field[0][1] == "x" and field[1][1] == "x" and field[2][1] == "x") or (field[0][2] == "x" and field[1][2] == "x" and field[2][2] == "x") or (field[0][0] == "x" and field[1][1] == "x" and [2][2] == "x") or (field[0][2] == "x" and field[1][1] == "x" and field[2][0] == "x"):
        print("победил игрок x")
        break
    print("Ходит игрок 0")
    line_number = int(input("Введите номер строки от 1 до 3: "))
    column_number = int(input("Введите номер столбца от 1 до 3: "))
    while line_number < 0 or line_number > 3 or column_number < 0 or column_number > 3:
        line_number = int(input("Введите номер строки от 1 до 3: "))
        column_number = int(input("Введите номер столбца от 1 до 3: "))
    while field[line_number - 1][column_number - 1] == "0" or field[line_number - 1][column_number - 1] == "x":
        print("Это место занято. Ходит игрок 0")
        line_number = int(input("Введите номер строки от 1 до 3: "))
        column_number = int(input("Введите номер столбца от 1 до 3: "))
    field[line_number - 1][column_number - 1] = "0"
    step += 1
    for i in range(len(field)):
        print("+-+-+-+")
        print(f"|{field[i][0]}|{field[i][1]}|{field[i][2]}|")
    print("+-+-+-+")
    print("-------------------------------")
    if (field[0][0] == "0" and field[0][1] == "0" and field[0][2] == "0") or (field[1][0] == "0" and field[1][1] == "0" and field[1][2] == "0") or (field[2][0] == "0" and field[2][1] == "0" and field[2][2] == "0") or (field[0][0] == "0" and field[1][0] == "0" and field[2][0] == "0") or (field[0][1] == "0" and field[1][1] == "0" and field[2][1] == "0") or (field[0][2] == "0" and field[1][2] == "0" and field[2][2] == "0") or (field[0][0] == "0" and field[1][1] == "0" and [2][2] == "0") or (field[0][2] == "0" and field[1][1] == "0" and field[2][0] == "0"):
        print("победил игрок 0")
        break
    if step == 9:
        print("Ничья")
        game = False


