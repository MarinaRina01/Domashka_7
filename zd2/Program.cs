// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = 3;
int colomns = 4;
int[,] matrix = GetRandomMatrix(rows, colomns, 0, 9);
PrintMatrix(matrix);
int num = SetNumber("");
(int, int) index = GetFoundNumber(matrix, num);
Console.WriteLine($"У элемента {num} строка  = {index.Item1} столбец = {index.Item2}");

int SetNumber(string text)
{
    Console.Write($"Введите число {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int colomns, int min, int max)
{
    int[,] array = new int[rows, colomns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;

}


(int, int) GetFoundNumber(int[,] matrix, int num)
{
    int matrixI = 0;
    int matrixJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num == matrix[i, j])
            {
                matrixI = i;
                matrixJ = j;
                return (matrixI, matrixJ);
            }
            else if (j == matrix.GetLength(1) -1 && i==matrix.GetLength(0)-1 && num!= matrix[i, j]) {
                Console.WriteLine("Такого элемента нет в массиве");
                return (-1,-1);
            }

        }
    }
    return (matrixI, matrixJ);
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

