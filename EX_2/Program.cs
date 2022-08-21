using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        int res = 0;
        for (int i = x; i > 0; i++)
        {

            res = res + x % 10;
            x = x / 10;
        }

        Console.WriteLine("Сумма чисел равна: " + res);
    }
}
