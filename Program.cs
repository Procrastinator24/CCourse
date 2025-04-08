using System;

class Program
{
    

    static void Main()
    {
        //Begin32
        Console.WriteLine("Введите температуру по Цельсию:");
        double t = Convert.ToDouble(Console.ReadLine());
        double f = t * 9 / 5 + 32;
        Console.WriteLine(f);


        //Integer12
        Console.WriteLine("Введите трехзначное число:");
        string digit =Console.ReadLine();
        for (int i = digit.Length - 1; i!=-1; i--)
        {
            Console.Write(digit[i]);
        }



    }
}