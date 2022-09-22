# Вам уже приходилось писать таблицу умножения. Но в этот раз вас попросили сделать в плюс к таблице и умножения еще таблицу сложения, а также таблицу возведения в степень.
# Что не копировать один и тот же код и обобщить все три функции до единой рисования таблиц (бинарных) арифметических операций, напишите функцию 
# print_operation_table(operation, num_rouws=9, num_colums=9), которая принимает в качестве аргумента функцию, вычисляющую элемент по номеру строки и столбца.
# Аргументы num_rows и num_columns указывают число строк и столбцов таблицы, которые должны быть распечатаны. Нумерация строк и столбцов идёт с единицы (подумайте, почему не с нуля).
# Примечание: бинарной операцией называется любая операция, у которой ровно два аргумента, как, например, у операции умножения.
# Пример 1
# print_operation_table(lambda x, y: x*y)
# [21:49]
# условие первой задачи.

def print_operation_table(operation, num_rows = 9, num_colums = 9):
    for i in range(1, num_rows + 1):
        for j in range(1, num_colums + 1):
            print(operation(i, j), "\t", end = '')
        print()

num1, num2 = (int(input("Введите числа ")) for i in range(2))
print('________________________')
print_operation_table(lambda x, y: x+y, num1)
print('________________________')
print_operation_table(lambda x, y: x*y, num1, num2)
print('________________________')
print_operation_table(lambda x, y: x**y, num2)

def MySignature():
    print("\n________________________\nthe program was implemented by Dmitry Pyanzin\n________________________\n")

MySignature()