"""
Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Пример:

- [2, 3, 4, 5, 6] => [12, 15, 16];
- [2, 3, 5, 6] => [12, 15]
"""
import math

arr = [int(i) for i in input("Введите числа: ").split()]
new_arr = list()
j = -1

for i in range(math.ceil(len(arr) / 2)):
    new_arr.append(arr[i] * arr[j])
    j -= 1

print(new_arr)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()