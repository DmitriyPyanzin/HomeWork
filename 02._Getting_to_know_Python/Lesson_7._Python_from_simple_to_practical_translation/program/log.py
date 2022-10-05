def read():
    flag = True
    print("Какой файл прочитать?\n")
    while flag:
        ans = input("1 - guide\n2 - new_guide\n")
        if ans == '1':
            with open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/guide.txt', 'r', encoding = 'UTF=8') as file:
                print(file.read())
                flag = not flag
        elif ans == '2':
            with open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/new_guide.txt', 'r', encoding = 'UTF=8') as file:
                print(file.read())
                flag = not flag
        else:
            print("Нажми 1 или 2")


def app():
    flag = True
    print("В какой файл дописать контакт?\n")
    while flag:
        ans = input("1 - guide\n2 - new_guide\n")
        if ans == '1':
            with open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/guide.txt', 'a+', encoding = 'UTF=8') as file:
                file.write('\n' + input())
                flag = not flag
        elif ans == '2':
            with open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/new_guide.txt', 'a+', encoding = 'UTF=8') as file:
                file.write('\n' + input())
                flag = not flag
        else:
            print("Нажми 1 или 2")

def imp():
    guide = open('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/guide.txt', 'a+', encoding = 'UTF=8')
    new_guide = open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/new_guide.txt', 'r', encoding = 'UTF=8')
    guide.write('\n' + new_guide.read())
    guide.close()
    new_guide.close()

def export():
    new_guide = open('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/new_guide.txt', 'a+', encoding = 'UTF=8')
    guide = open ('g:/i_am_programmer/my_programs/HomeWork/02._Getting_to_know_Python/Lesson_7._Python_from_simple_to_practical_translation/program/guide.txt', 'r', encoding = 'UTF=8')
    new_guide.write('\n' + guide.read())
    guide.close()
    new_guide.close()