// Так как в задаче не указано число целое или вещественное, буду использовать тип double;
// В задаче написан вопрос "какое большее, а какое меньшее", поэтому я не искал только максимум, но и минимум;
Console.Write("Введите первое число: ");
double num1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToInt64(Console.ReadLine());

if(num1 < num2) Console.Write($"Число {num2} больше числа {num1}");
else if(num1 > num2) Console.Write($"Число {num1} больше числа {num2}");
else Console.Write($"Числа {num1} и {num2} равны");