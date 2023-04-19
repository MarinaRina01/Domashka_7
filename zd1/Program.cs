// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = SetNumber("rows");
int colomns = SetNumber("colomns");
double [,] matrix = GetRandomMatrix(rows, colomns, -10, 10);
PrintMatrix(matrix);


int SetNumber(string text)
{
    Console.Write($"Введите число {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double [,] GetRandomMatrix(int rows, int colomns, int min, int max)
{
    double [,] array = new double [rows, colomns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(min,max +1) + rand.NextDouble(), 1);

        }
    }
    return array;

}

void PrintMatrix(double[,] matrix)
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

