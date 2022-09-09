"""
Требуется найти наименьший натуральный делитель целого числа N, отличный от 1.
Входной файл INPUT.TXT содержит целое число N (1 < N ≤ 10**6).
В выходной файл OUTPUT.TXT выведите ответ на задачу.
"""

print()
num = int(input("Введите число: "))
delit = 2
print()

while True:
    if num % delit == 0:
        break
    delit += 1
print(f"Наименьший целый делитель числа равен {delit}")

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()