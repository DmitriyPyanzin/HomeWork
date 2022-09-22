# 2. Мимикрия
# У вас есть код, который вы не можите менять (так часто бывает, когда код  глубине программы используется множество раз и вы не хотите ничего сломать):
# transformation = <???>
# values = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]
# trasformed_values = list(map(transformation, values))
# Единственный способ вашего взаимодействия с этим кодом - посредством задания функции transformation.
# Однако вы поняли, что для вашей текущей задачи не нужно никак преобразовывать список значений, а нужно получить его как есть.

# Напишите такое лямбда-выражение transformation, чтобы trasformed_values получился копией values. Переменная transformation должна быть глобальной, чтобы проверяющая система смогла ее найти.
# Кроме transformation вам ничего писать не нужно. Печать на экран - тоже.

values = [i for i in input().split()]
transformation = lambda x: x    # lambda функция
transformation_values = list(map(transformation, values))
if values == transformation_values: print('ok')
else: print('fail')

def MySignature():
    print("\n________________________\nthe program was implemented by Dmitry Pyanzin\n________________________\n")

MySignature()