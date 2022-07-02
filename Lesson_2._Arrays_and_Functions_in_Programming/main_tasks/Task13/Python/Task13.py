number = int(input("Введите число: "))
lennumber = len(str(abs(number)))
if lennumber < 3:
    print("Третьей цифры нет!")
else:
    print(abs(number) % 10**(lennumber - 2) // 10**(lennumber - 3))