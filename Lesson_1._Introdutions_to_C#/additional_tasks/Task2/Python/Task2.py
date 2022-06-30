print("Введите 2 числа так, чтобы первое было меньше второго: ")
first_num, second_num = (float(input()) for i in range(2))
print(f"В число {second_num} вмещается число {first_num} целиком {second_num % first_num} раз")