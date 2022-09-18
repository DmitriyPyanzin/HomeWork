# 4. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.

string = input() + ' '
count = 1

for i in range(len(string)-1):
    if string[i] == string[i + 1]:
        count += 1
    else:
        print(str(count) + string[i], end = '')
        count = 1

def MySignature():
    print("\n________________________\nthe program was implemented by Dmitry Pyanzin\n________________________\n")

MySignature()