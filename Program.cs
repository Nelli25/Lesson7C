// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.WriteLine("Введите количество строк, m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов, n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i, j] + " ");  
        }
    }
    
}

FillArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк, k: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов, l: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = new int [k, l];
Console.WriteLine("Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());
FillArray(secondMatrix);
PrintMatrix(secondMatrix);
FindElement(secondMatrix, position);
Console.ReadLine();

void FindElement(int[,] secondMatrix, int position)
{
    int count = 0;

    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            if (secondMatrix[i, j] == position)
                Console.WriteLine($"Элемент массива со значением {position} находится на позиции {i}, {j}");
            else count++;
        }
    }
    Console.WriteLine();
    if (secondMatrix.GetLength(0) * secondMatrix.GetLength(1) == count)
        Console.WriteLine($"Элемент {position} не найден.");
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк, a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов, b: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] thirdMatrix = new int [a, b];

FillArray(thirdMatrix);
PrintMatrix(thirdMatrix);
AvarageElements(thirdMatrix);
Console.ReadLine();

void AvarageElements (int[,] thirdMatrix)
{
    double sum = 0;
    double [] avarage = new double[thirdMatrix.GetLength(1)];
    for (int i = 0; i < thirdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdMatrix.GetLength(1); j++)
        {
            sum += thirdMatrix[i, j];
        }
        avarage[i] = sum / thirdMatrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов в {i} столбце: {avarage[i]}");
    }
    
}
