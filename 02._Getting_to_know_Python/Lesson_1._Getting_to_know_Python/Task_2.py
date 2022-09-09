"""
Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.
"""

print()
x, y, z = (int(input("Введите число: ")) for i in range(3))

left = not (x or y or z)
right = not x and not y and not z

print()
print(left == right)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()