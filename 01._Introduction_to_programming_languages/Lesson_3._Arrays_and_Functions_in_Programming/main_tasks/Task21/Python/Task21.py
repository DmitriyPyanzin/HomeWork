from math import sqrt
x1, y1, z1 = (int(input("Введите координаты первой вершины: ")) for i in range(3))
x2, y2, z2 = (int(input("Введите координаты второй вершины: ")) for i in range(3))
print(f"Длина отрезка равна {sqrt((x1 - x2)**2 + (y1 - y2)**2 + (z1 - z2)**2)}")

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin");
    print("________________________")

MySignature()