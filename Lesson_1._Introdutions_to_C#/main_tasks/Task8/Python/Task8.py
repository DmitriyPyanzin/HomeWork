number, count = int(input("Введите число больше 2: ")), 2
if number < 2:
    print("Введено не то число!")
while count <= number:
    print(f"{count}, ", end = "")
    count += 1
print("ВСЁ!")