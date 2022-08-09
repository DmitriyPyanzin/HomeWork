print("Скажите свою дату рождения")
day, month, year = (int(input()) for i in range(3))
age = 2022 - year
if month > 7 or month == 7 and day > 1:
    print(age - 1)
else:
    print(age)