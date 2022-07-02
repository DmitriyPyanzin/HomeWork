void FindDay(int currentNumber)
{
    string[] array = {"Понедельник день тяжелый", "Вторник - я обязательно выживу", "Среда прошла - неделя прошла", "Четверг это маленькая пятница", "И теперь как в песне Слепакова - 'Каждую пятницу я в г*вно!'", "Сегодня Суббота и я буду лежать весь день", "Воскресенье, блин завтра же на работу"};
    if (0 < currentNumber && currentNumber < 8) Console.WriteLine(array[currentNumber - 1]);
    else Console.WriteLine("Что же ты ввел? Ты что не знаешь что дней в неделе всего 7!");
}

Console.Write("Введите номер дня недели! ");
int number = Convert.ToInt32(Console.ReadLine());
FindDay(number);