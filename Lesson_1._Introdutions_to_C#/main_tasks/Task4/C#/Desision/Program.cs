//В условии задачи не сказано, что числа будут именно целые и поэтому использую тип double
Console.Write("Введите первое число: ");
double num1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToInt64(Console.ReadLine());
double max = num1;

if(max < num2) max = num2;
if(max < num3) max = num3;

Console.WriteLine($"Максимальное число из трех введенных равно {max}");