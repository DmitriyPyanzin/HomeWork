Console.Write("Введите число секунд: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write($"Это {second / 3600} час (-ов), {second % 3600 / 60} минут (-а), {second % 60} секунд (-а).");