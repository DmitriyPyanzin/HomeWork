"""
Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.
В единственной строке входного файла INPUT.TXT записано единственное целое число N, не превышающее по абсолютной величине 10**4.
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел, расположенных между 1 и N включительно.
"""

print()
n = int(input("Введите число: "))
sum = 0
print()

for i in range(2, n):
    sum += i
print(sum)

def MySignature():
    print()
    print("________________________")
    print("the program was implemented by Dmitry Pyanzin")
    print("________________________")
    print()

MySignature()