print()
money = int(input("Сколько денег мы положим? "))
month = int(input("На сколько месяцев? "))

def how_money(num):
    for i in range(month):
        num += num * 0.015
    print("Вот сколько денег", round(num, 2))

how_money(money)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin");
    print("________________________")

MySignature()