"""
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Пример:
- 6 -> да
- 7 -> да
- 1 -> нет
"""

def foolproof(num):
    if num.isdigit() and 1 <= int(num) <= 7:
        return True
    else:
        return False

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

while True:
    print()
    number = input("Введите число от 1 до 7: ")
    if foolproof(number) == False:
        print()
        print("Что-то ты друждок-пирожок не то ввел! Нужно от 1 до 7")
    else:
        print()
        if int(number) == 1: print("Понедельник - день тяжелый!")
        elif int(number) == 2: print("Вторник - все еще тяжело!")
        elif int(number) == 3: print("Среда прошла - неделя прошла!")
        elif int(number) == 4: print("Четверг - это меленькая пятница!")
        elif int(number) == 5: print("Каждую пятницу я в Г**НО!")
        elif int(number) == 6: print("Суббота! Сегодня я никуда не пойду!")
        else: print("Воскресенье! Запвтра на работу! Плак! Плак!")
        break

MySignature()