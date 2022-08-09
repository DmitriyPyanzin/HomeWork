Console.Write("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число, чтобы оно было больше {first_num}: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if(first_num >= second_num) Console.WriteLine("Ты дурак?");
Console.WriteLine($"Число {first_num} влазиет в {second_num} только {second_num / first_num} раз(-а)");