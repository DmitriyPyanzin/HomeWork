"""
Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
"""

arr, new_arr = [int(i) for i in input().split()], list()
for i in range(len(arr)):
    if arr.count(arr[i]) == 1: new_arr.append(arr[i])
print(*new_arr)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()