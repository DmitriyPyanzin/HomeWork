# 4. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.

with open('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_5._Accelerated_data_processing/Task_3.txt', 'w', encoding = 'utf-8') as file:
    file.write(input())

with open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_5._Accelerated_data_processing/Task_3.txt', 'r', encoding = 'utf-8') as file:
    string = file.read() + ' '

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