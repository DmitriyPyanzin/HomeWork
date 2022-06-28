print("Введите 3 числа, нажимая клавишу 'Enter' после каждого!")
num1, num2, num3 = [float(input()) for i in range(3)]
print(num1, num2, num3)

print(f"Самое большое число из введенных {max(num1, num2, num3)}")