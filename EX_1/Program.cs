using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 1 число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int res = 1;

        for (int i = 0; i < y; i++)
        {
            res = res * x;

        }

        Console.WriteLine(res);
    }
}
