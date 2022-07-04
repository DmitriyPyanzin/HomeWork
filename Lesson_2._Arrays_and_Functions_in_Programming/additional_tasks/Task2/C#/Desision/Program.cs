Console.Clear();
Console.Write("Введите год рождения: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер месяца рождения: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите день рождения рождения: ");
int day = Convert.ToInt32(Console.ReadLine());

int age = 2022 - year;
if(month > 7) Console.WriteLine("Вам " + (age - 1) + " года (лет)");
else if(month == 7 && day > 1) Console.WriteLine("Вам " + (age - 1) + " года (лет)");
else Console.WriteLine("Вам " + (age) + " года (лет)");