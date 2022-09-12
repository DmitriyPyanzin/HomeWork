"""
Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

Пример:

- [1.1, 1.2, 3.1, 5, 10.01] => 0.19
"""

arr = [float(i) for i in input("Введите числа: ").split()]
new_arr = list()

for i in range(len(arr)):
    if int(arr[i]) == arr[i]: continue
    new_arr.append(round(arr[i] - int(arr[i]), 5))

print(max(new_arr) - min(new_arr))

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()