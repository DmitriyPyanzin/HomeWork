"""
Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.(Доп)

Пример:

- для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]
"""

def fib(num):
    if num in [1, 2]:
        return 1
    else:
        return fib(num - 1) + fib(num - 2)

arr = [0]
number = int(input("Сколько чисел из ряда Негафибоначчи ты хочешь увидеть? "))

for i in range(1, number + 1):
    arr.append(fib(i))
    if i % 2 == 0:
        arr.insert(0, fib(i) * -1)
    else:
        arr.insert(0, fib(i))
    print(arr)
print(arr)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()