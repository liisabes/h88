// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();

int InputM()
{
    Console.Write("Введите количество строк m: ");
    int m = 0;
    while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
    {
        Console.Write("Введите количество строк m: ");
    }
    return m;
}
int InputN()
{
    Console.Write("Введите количество столбцов n: ");
    int n = 0;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Введите количество столбцов n: ");
    }
    return n;
}
int m = InputM();
int n = InputN();

void Logic(int m, int n)
{
    Random random = new Random();
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Logic(m, n);
