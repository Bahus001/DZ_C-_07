// Задача 50. 
// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


Console.WriteLine("Введите элемент двух мерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int colums = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int ValueOutputMatrix(int[,] matrix)
{
    int sum = 0;
    if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1))
        sum = (matrix[rows, colums]);
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int res = ValueOutputMatrix(array2D);
if (rows < array2D.GetLength(0) && colums < array2D.GetLength(1))
    Console.WriteLine($"{rows},{colums} -> {res}");
else
    Console.WriteLine($"{rows},{colums} -> такого числа в массиве нет");




