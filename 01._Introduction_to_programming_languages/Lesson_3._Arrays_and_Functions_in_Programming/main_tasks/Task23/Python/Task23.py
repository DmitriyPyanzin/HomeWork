def find_cube(num):
    for i in range(num):
        print((i + 1)**3, end = ", ")

find_cube(int(input("Введите число: ")))
print("OK")


def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin");
    print("________________________")

MySignature()
