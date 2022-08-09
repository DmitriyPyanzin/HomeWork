//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()                                                                         //Главный метод
{
    Console.Clear();
    Console.WriteLine("Данная программа выводит наименьшую сумму в строках массива");
    Console.WriteLine();
    Console.WriteLine("Давай создадим массив из целых чисел, но он должен быть прямоугольный!");
    Console.WriteLine();
    Console.Write("Какой длины будет массив: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Какой ширины будет массив: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    int[] newArray = new int[rows];

    if (rows == columns)
    {
        Console.WriteLine();
        Console.WriteLine("Но, но, но! Не надо хитрить, числа должны быть разные!");
    }

    else
    {
        FillMatrix(matrix, rows, columns);
        PrintMatrix(matrix, rows, columns);
        SumElementRow(matrix, newArray, rows, columns);
        Printarray(newArray, rows);
        FindMinSum(newArray, rows);
    }
}

int[,] FillMatrix(int[,] array, int rows, int columns)                                //Метод заполнения двумерного массива
{
    Random rand = new Random();
    Console.WriteLine();
    Console.WriteLine("А теперь определим диапозон чисел");
    Console.WriteLine();
    Console.Write("От кагого числа заполнять массив: ");
    int firstNum = int.Parse(Console.ReadLine());
    Console.Write("До кагоко числа заполнять массив: ");
    int secondNum = int.Parse(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(firstNum, secondNum);
        }
    }
    return array;
}

void PrintMatrix(int[,] array, int rows, int columns)                                 //Метод вывода массива двумерного массива
{
    Console.WriteLine();
    Console.WriteLine("Вот такой двумерный массив получился!");
    Console.WriteLine();
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}

int[] SumElementRow(int[,] array, int[] newArray, int rows, int columns)            //Метод заполнения одномерного массива
{
    int sum;
    for (int i = 0; i < rows; i++)
    {
        sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
		newArray[i] = sum;
    }
	return newArray;
}

void Printarray(int[] array, int rows)                                 //Метод вывода одномерного массива
{
    Console.WriteLine();
    Console.WriteLine("Вот такой одномерный массив получился!");
    Console.WriteLine();
    
    for (int i = 0; i < rows; i++) Console.Write(array[i] +"\t");
    Console.WriteLine();
}

void FindMinSum(int[] array, int rows)                      //Метод поиска минимального элемента
{
	int min = array[0];
	int index = 0;
    int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(min > array[i])
		{
			min = array[i];
			index = i;
            count++;
		}
        else if (min == array[i]) count++;
	}
    if(count == 1)
    {
        Console.WriteLine();
	    Console.WriteLine($"В строке {index + 1} самая самая маленькая сумма {min}");
    }
    else if (count > 1)
    {
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) Console.WriteLine($"В строке {i + 1} самая самая маленькая сумма {min}");
        }
    }
    
}

void MySignature()                                              //Метод подписи
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha56();
MySignature();