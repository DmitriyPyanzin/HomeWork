"""
Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

Пример:

- [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
"""

arr = [int(i) for i in input("Введите числа: ").split()]

# 1-й вариант

summa = 0
for i in range(len(arr)):
    if i % 2 == 1: summa += arr[i]
print(summa)

# 2-й вариант

new_arr = list()
for i in range(len(arr)):
    if i % 2 == 1: new_arr.append(int(arr[i]))
print(sum(new_arr))

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()