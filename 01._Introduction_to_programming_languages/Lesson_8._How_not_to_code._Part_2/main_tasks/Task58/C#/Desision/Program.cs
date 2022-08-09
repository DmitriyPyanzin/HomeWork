//Задача 58. Заполните спирально массив 4 на 4.
/*
void Zadacha58()                        //Главный метод
{
    Console.Clear();
    Console.WriteLine("Ходят слухи, что индусы не умеют пользоваться циклами и каждый элемент массива прописывают вручную!");
    Console.WriteLine();
    string answer;
    int checkNum;

    do
    {
        Console.WriteLine("Внимание вопрос? Будем решать как индусы или как программисты?");
        Console.WriteLine();
        Console.Write("Введите соответственно 'Hindu' или 'IAmProgrammer' ");
        answer = Console.ReadLine().ToLower();
        Console.WriteLine();
        checkNum = answer == "hindu" || answer == "iamprogrammer"? 1:0;
    }
    while (checkNum != 1);

    if (answer == "hindu")
    {
        int size = 4;
        int[,] matrix = new int[4, 4];
        HindySolution(matrix);
    }
    else
    {
        int size = 4;
        int[,] matrix = new int[size, size];

        FillArray(matrix, size);
        PrintMatrix(matrix, size);
    }
}

void HindySolution(int[,] array)                        //Метод индусов
{
    array[0, 0] = 1;
    Console.Write(array[0, 0] + "\t" + "\t");
    array[0, 1] = 2;
    Console.Write(array[0, 1] + "\t" + "\t");
    array[0, 2] = 3;
    Console.Write(array[0, 2] + "\t" + "\t");
    array[0, 3] = 4;
    Console.Write(array[0, 3] + "\t" + "\t");
    Console.WriteLine();
    array[1, 0] = 12;
    Console.Write(array[1, 0] + "\t" + "\t");
    array[1, 1] = 13;
    Console.Write(array[1, 1] + "\t" + "\t");
    array[1, 2] = 14;
    Console.Write(array[1, 2] + "\t" + "\t");
    array[1, 3] = 5;
    Console.Write(array[1, 3] + "\t" + "\t");
    Console.WriteLine();
    array[2, 0] = 11;
    Console.Write(array[2, 0] + "\t" + "\t");
    array[2, 1] = 16;
    Console.Write(array[2, 1] + "\t" + "\t");
    array[2, 2] = 15;
    Console.Write(array[2, 2] + "\t" + "\t");
    array[2, 3] = 6;
    Console.Write(array[2, 3] + "\t" + "\t");
    Console.WriteLine();
    array[3, 0] = 10;
    Console.Write(array[3, 0] + "\t" + "\t");
    array[3, 1] = 9;
    Console.Write(array[3, 1] + "\t" + "\t");
    array[3, 2] = 8;
    Console.Write(array[3, 2] + "\t" + "\t");
    array[3, 3] = 7;
    Console.WriteLine(array[3, 3] + "\t" + "\t");
    Console.WriteLine();
    Console.WriteLine("\t" + "\t" + "ХОБА!!!!!");
}

int[,] FillArray(int[,] array, int size)                //Метод заполнения массива
{
    int count = 0;
    int i = 0;
    int j = 0;

    while (count <= size * size)       
    {
        count++;

        if (i == 0 && j < size && count < size)                 //1-4 итерации
        {
            array[i, j] = count;
            j++;
        }
        

        else if (i == 0 && j == size)           //5 итерация
        {
            i++;
            j--;
            count--;
        }

        else if (i < size  && j == size - 1 && count < size * 2)    //6-8 итерации
        {
            array[i, j] = count;
            i++;
        }

        else if (i == size && j == size - 1)        //9 итерация
        {
            j--;
            i--;
            count--;
        }
        
        else if (i == size - 1 && j > -1 && count < size * 3)           //10-12 итерации
        {
            array[i, j] = count;
            j--;
        }

        else if (i == size - 1 && j == -1)          //13 итерация
        {
            count--;
            j++;
            i--;
        }

        else if (i > 0 && j == 0)                   //14-15 итерации
        {
            array[i, j] = count;
            i--;
        }

        else if (i == 0 && j == 0)                  //16 итерация
        {
            count--;
            i++;
            j++;
        }

        else if (i == 1 && j < size - 1 && count > 10)      //17-18 итерации
        {
            array[i, j] = count;
            j++;
        }

        else if (i == 1 && j == size - 1)               //19 итерация
        {
            count--;
            j--;
            i++;
        }

        else if (i < size - 1 && j == size - 2)         //20 итерация
        {
            array[i, j] = count;
            i++;
        }

        else if (i == size - 1 && j == size - 2) array[i - 1, j - 1] = count - 1;        //21 итерация
    }
    
    return array;
}

void PrintMatrix(int[,] array, int size)                //Метод вывода массива
{
    Console.WriteLine();
    Console.WriteLine("Вот такой массив получился!");
    Console.WriteLine();
    
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}

void MySignature()                                      //Моя подпись
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha58();
MySignature();
*/
Console.Clear();
int size = int.Parse(Console.ReadLine());
int[,] array = new int[size, size];
int count = 0;
int i = -1;
int j = -1;
int num = -1;
int perimeter = 0;
int numSize = -1;

while (count <= size * size)
{
    if (count == perimeter)
    {
        num += 2;
        perimeter += (size - num) * 4;
        i++;
        j++;
        numSize++;
    }
    if (i == numSize)
    {
        count++;
        array[i, j] = count;
        Console.WriteLine(array[i, j]);
        j++;
        if (j == size - 1 - numSize) i++;
        
    }
    else if (j == size - 1 - numSize)
    {
        count++;
        array[i, j] = count;
        Console.WriteLine(array[i, j]);
        i++;
        if (i == size - 1 - numSize) j--;
    }
    else if (i == size - 1 - numSize)
    {
        count++;
        array[i, j] = count;
        Console.WriteLine(array[i, j]);
        j--;
        if (j == numSize) i--;
    }
    else if (j == numSize)
    {
        count++;
        array[i, j] = count;
        Console.WriteLine(array[i, j]);
        i--;
     }
}

void PrintMatrix(int[,] array, int size)                //Метод вывода массива
{
    Console.WriteLine();
    Console.WriteLine("Вот такой массив получился!");
    Console.WriteLine();
    
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(array, size);