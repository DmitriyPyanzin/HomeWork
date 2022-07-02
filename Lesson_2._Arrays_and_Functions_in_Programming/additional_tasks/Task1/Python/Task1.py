def TriangleViev(a, b, c):

    if a == b == c:
        print("Треугольник равносторонний!")
    elif a == b or b == c or a == c: 
        print("Треугольник равнобедренный!")
    else:
        print("Треугольник не равнобедренный")

num1, num2, num3 = (int(input("Введите длинну стороны:")) for i in range(3))
TriangleViev(num1, num2, num3)