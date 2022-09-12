"""
Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Пример:

- 45 -> 101101
- 3 -> 11
- 2 -> 10
"""

number = int(input("Введите десятичное число, а я покажу тебе его двоичным: "))

# 1-й вариант

print(bin(number)[2:])

# 2-й вариант

binary = list()
arr = list()

while number > 0:

    binary.insert(0, str(number % 2))
    arr.append(str(number % 2))
    number //= 2

print(''.join(binary))

# 3-й Вариант

arr.reverse()

for i in range(len(arr)):
    print(arr[i], end = "")

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()