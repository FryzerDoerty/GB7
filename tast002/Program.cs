//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Main()
{
    int[,] array = new int[3, 4];
    FillMatrix(array);
    PrintArray(array);
    int a = FillArray("Введите строку");
    int b = FillArray("Введите столбец");
    Rezult(a, b, array);


}
void Rezult(int a, int b, int[,] array)
{
    int re = 0;
    if (a <= array.GetLength(0) && b <= array.GetLength(1))
    {
        re = array[a-1 , b-1]; //Здесь считается, что пользователь нумерует не с нуля колонки и столбцы
        //re = array[a, b]; //Работало бы, если бы в сравнении было строго больше
        System.Console.WriteLine(re);
    }
    else
    {
        System.Console.WriteLine("Такого элемента нет");
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

int FillArray(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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
