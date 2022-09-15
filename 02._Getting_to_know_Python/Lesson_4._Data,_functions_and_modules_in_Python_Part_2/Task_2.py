"""
Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
"""

num = int(input("Введите число, а я выведу его простые множители "))
i = 2
while i <= num: 
    if num % i == 0:
        print(i, end = " ")
        num //= i
        i = 1
    i += 1


def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()