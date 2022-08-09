Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirdNum(number);

void FindThirdNum(int currentNumber)
{
    int absNumber = Math.Abs(currentNumber);
    int len = Convert.ToString(absNumber).Length;
    if(len < 3) Console.WriteLine("Третьей цифры нет");
    else Console.WriteLine($"У числа {currentNumber} третья цифра {Convert.ToInt32(absNumber % Math.Pow(10, len - 2)) / Convert.ToInt32(Math.Pow(10, len - 3))}");
}

//Метод вроде бы легкий, но пришлось поломать голову, т.к. в ответе выводилось вещественное число (например у чиса 98765 третье 7,65),
//и вылечелось это только переводом в целочисленное, причем по отдельности, 
//потому что если все обьединить в ToInt32 то число округлялось. И кстати Денис, у меня вопрос:

//Почему при Convert.ToInt32(absNumber % Math.Pow(10, len - 2) / Math.Pow(10, len - 3)) при введении числа 98765 выводил 8, он же должен был просто отбрасывать остаток, а не округлять??????