using System;

class Program
{
    static void Main(string[] args)

    {

        Console.WriteLine("Введите размерность массива:");
        int i, n = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int[n];
        Console.WriteLine("Введите массив:");
        string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
            mas[i] = Convert.ToInt32(str[i]);
        Console.WriteLine("Введенный массив:");
        Console.Write("[ ");

        for (i = 0; i < n; ++i)
            Console.Write(mas[i] + ",");

        Console.Write("]");
        Console.ReadLine();
    }
}