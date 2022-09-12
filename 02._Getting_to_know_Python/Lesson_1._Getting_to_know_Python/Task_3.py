"""
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).

Пример:

- x=34; y=-30 -> 4
- x=2; y=4-> 1
- x=-34; y=-30 -> 3
"""

print()
x, y = int(input("Введите координату 'X': ")), int(input("Введите координату 'Y': "))
print() 

if x == y: print("Координаты 'Х' и 'Y' не должны быть равны")
elif x > 0:
    if y == 0: print("Точка находится на оси 'X'")
    elif y > 0: print("Точка находится в I четверти")
    else: print("Точка находится в IV четверти")
elif x < 0:
    if y == 0: print("Точка находится на оси 'X'")
    elif y > 0: print("Точка находится во II четверти")
    else: print("Точка находится в III четверти")
else: print("Точка находится на оси 'Y'")

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()