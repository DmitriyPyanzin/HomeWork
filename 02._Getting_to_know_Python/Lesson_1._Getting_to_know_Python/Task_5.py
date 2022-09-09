"""
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Пример:
- A (3,6); B (2,1) -> 5,09- A (7,-5); B (1,-1) -> 7,21
"""
import math

print()
x1, y1 = (int(input("Введите координаты первой точки: ")) for I in range(2))
print()
x2, y2 = (int(input("Введите координаты второй точки: ")) for I in range(2))

print()
print(f'Расстояние между точками {round(math.sqrt((x2 - x1)**2 + (y2 - y1)**2), 2)}')

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()