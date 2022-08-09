void NumPow()
{
	//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
	//и возводит число A в натуральную степень B
	
	Console.Clear();
	Console.Write("Введите число: ");
	int multiA = Convert.ToInt32(Console.ReadLine());
	Console.Write($"Введите степень, в которую необходимо возвести число {multiA}: ");
	int multiB = Convert.ToInt32(Console.ReadLine());
    int multi = FindPow(multiA, multiB);
    Console.WriteLine($"Если число {multiA} возвести в степень {multiB} то мы получим число {multi}");
}

int FindPow(int numA, int numB)
{
    int newNumA = numA;
    for(int i = 1; i <  numB; i++)
    {
        newNumA *= numA;
    }
    return newNumA;
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

NumPow();
MySignature();