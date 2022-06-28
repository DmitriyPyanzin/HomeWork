//Даже если на ввод прийдет число вещественное, на выводе будут числа целочисленные;
// и поэтому используем тип int;
Console.Write("Привет! Введи число не меньше 2: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(number < 2) Console.WriteLine("Ты чё ввел!!! Сказано же не меньше 2.");
else
{
    while(count <= number)
    {
        Console.Write($"{count}, ");
        count++;
    }
    Console.WriteLine($"Вот все четные числа от 1 до {number} включительно!");
}

Console.WriteLine("Пока, пока!!!!");