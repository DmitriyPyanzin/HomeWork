# Задача про Винни_Пуха

vowel = 'аеёиоуэюя'
words = input().split()
res = list()

for i in words:
    res.append([j for j in i if j in vowel])    # Списочное выражение

res = (list(map(lambda x: len(x), res)))        # lambda выражение и функция высшего порядка

if sum(res) % len(res) == 0: print('Парам пам-пам')
else: print('Пам парам')

def MySignature():
    print("\n________________________\nthe program was implemented by Dmitry Pyanzin\n________________________\n")

MySignature()