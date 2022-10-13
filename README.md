# h88
//внесла изменения в Task003
// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

int m = InputM();
int n = InputN();

int[,] numbers = new int[m, n];
FillArr(m, n, numbers);
PrintArr(m, n, numbers);
ArifmN(numbers);


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
void FillArr(int m, int n, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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
void ArifmN(int [,] numbers)
{
    double summ = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        summ = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            summ +=  numbers[i, j];
        }
        Console.WriteLine(summ/numbers.GetLength(0));
    }
}
