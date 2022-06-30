Console.Write("Введите число больше 0: ");
double number = Convert.ToInt64(Console.ReadLine());
while(number >= 1)
{
    Console.Write("1, ");
    number--;
}
Console.WriteLine("ВСЁ!");