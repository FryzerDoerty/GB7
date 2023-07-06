
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void Main()
{
    int column = KeyboardInput("Введите число колонок:");
    int line = KeyboardInput("Введите число строк:");
    int row = KeyboardInput("Введите начало генерации:");
    int col = KeyboardInput("Введите конец генерации:");
    double[,] array = new double[line, column];
    FillMatrix(array, col, row);
    PrintArray(array);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int KeyboardInput(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void FillMatrix(double[,] arr, int col, int row)
{
    //double[,] arr = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rand.Next(row, col + 1) + rand.NextDouble(), 3);
        }
    }
}
Main();
