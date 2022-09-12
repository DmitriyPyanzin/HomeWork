"""
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.
"""

print()
num = int(input("Сколько элементов будет в списке? "))
print()
arr = [int(input("Введите число: ")) for i in range(num)]
new_arr = [0 for i in range(num)]
print()
shift = int(input("Введите число, на которое необходимо сдвинуть список: "))
count_shift = None
print()

if abs(shift) > num: 
    if shift > 0: shift %= num
    else: shift = abs(shift) % num * -1

for i in range(num):
    if shift > 0:
        count_shift = i + shift
        if count_shift >= num: count_shift -= num
    elif shift < 0:
        count_shift = i + shift
        if count_shift < 0: count_shift += num
    new_arr[count_shift] = arr[i]

print()
print(f"Что было {arr}")
print(f"Что стало {new_arr}")

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()