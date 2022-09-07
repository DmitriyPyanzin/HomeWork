"""
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
"""

def foolproof(x):
    if x.isdigit() and 1 <= int(x) <= 4: return True
    else: return False

while True:
    print() 
    num = input("Введите номер четверти от 1-го до 4-х ")

    if foolproof(num) == False:
        print()
        print("Числа должны быть от 1 до 4, а не то, что ты ввёл!")

    else:
        print() 
        if num == '1': print("В 1-й четверти значения X > 0 и Y > 0")
        elif num == '2': print("Во 2-й четверти значения X < 0 и Y > 0")
        elif num == '3': print("В 3-й четверти значения X < 0 и Y < 0")
        else: print("В 4-й четверти значения X > 0 и Y < 0")
        break

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()