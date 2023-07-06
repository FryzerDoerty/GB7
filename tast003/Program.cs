//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Main()
{
    int str = 3;
    int col = 4;
    int[,] array = new int[str, col];
    FillMatrix(array);
    PrintArray(array);
    Rezult(array, col, str);
}

void Rezult(int[,] array, int col, int str)
{
    int sum;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];

        }
        int rez = sum / str;
        int re = sum % str;
        if (re > 0)
        {
            System.Console.Write(rez + "," + re + "; ");
        }
        else { System.Console.Write(rez + "; "); }
    }

}
void PrintArray(int[,] array)
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

void FillMatrix(int[,] arr)
{
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
}
Main();
