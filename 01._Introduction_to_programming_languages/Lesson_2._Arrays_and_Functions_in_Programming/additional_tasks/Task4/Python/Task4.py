# Задача 4. Дано натуральное число, в котором все цифры различны. 
# Определить, какая цифра расположена в нем левее: максимальная или минимальная.

def find_max_min(num):
    max = 0
    min = 10
    countmin = 0
    countmax = 0
    n = len(str(num))
    while 0 < num:
        if num % 10 > max:
            max = num % 10
            countmax = n
        if num % 10 < min:
            min = num % 10
            countmin = n
        n -= 1
        num //= 10
    if countmax < countmin:
        print(f"Максимальное число {max} левее минимального числа {min}")
    else:
        print(f"Максимальное число {max} правее минимального числа {min}")


find_max_min(int(input("Введите натуральное число состоящее из различных цифр: ")))

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin");
    print("________________________")

MySignature()