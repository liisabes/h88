// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.Clear();
int m = InputM();
int n = InputN();
int mPosition = InputMPosition(m);
int nPosition = InputNPosition(n);
int[,] numbers = new int[m, n];
FillArr(m, n, numbers);
PrintArr(m, n, numbers);
Logic(mPosition, nPosition, numbers);

int InputM()
{
    Console.Write("Введите количество строк m: ");
    int m = 1;
    while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
    {
        Console.Write("Введите количество строк m: ");
    }
    return m;
}
int InputN()
{
    Console.Write("Введите количество столбцов n: ");
    int n = 1;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Введите количество столбцов n: ");
    }
    return n;
}
int InputMPosition(int m)
{
    Console.Write("Введите позицию строки m, начиная с 0: ");
    int mPosition = 0;
    while (!int.TryParse(Console.ReadLine(), out mPosition) || mPosition < 0)
    {
        Console.Write("Введите позицию строки m, начиная с 0: ");
    }
    return mPosition;
}
int InputNPosition(int n)
{
    Console.Write("Введите позицию столбца n, начиная с 0: ");
    int nPosition = 0;
    while (!int.TryParse(Console.ReadLine(), out nPosition) || nPosition < 0)
    {
        Console.Write("Введите позицию строки n, начиная с 0: ");
    }
    return nPosition;
}
void FillArr(int m, int n, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}
void PrintArr(int m, int n, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Logic(int mPosition, int nPosition, int [,] numbers)
{
    if (mPosition > numbers.GetLength(0) || nPosition > numbers.GetLength(1))
    {
        Console.WriteLine("Данной позиции не существует");
    }
    else
    {
        Console.WriteLine($"Число найдено: {numbers[mPosition, nPosition]}");
    }
}