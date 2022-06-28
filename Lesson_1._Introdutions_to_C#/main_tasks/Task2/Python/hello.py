num1, num2 = float(input("Введите первое число: ")), float(input("Введите второе число: "))
if num1 < num2:
    print(f"Число {num2} больше чем число {num1}")
elif num1 > num2:
    print(f"Число {num1} больше чем число {num2}")
else:
    print(f"Числа {num1} и {num2} равны")