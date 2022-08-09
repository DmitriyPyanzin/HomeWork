def FindPolindrom(num):

    if 1 <= num // 10**4 <= 9:
        list = []
        while num != 0:
            list.append(num % 10)
            num //= 10
        if list[0] == list[4] and list[1] == list[3]:
            return print("Да! Это полиндром")
        else:
            return print("Нет, это не полиндром")

FindPolindrom(int(input("Введите пятизначное число: ")))