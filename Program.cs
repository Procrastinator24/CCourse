﻿using System;

class Program
{


    static void Main()
    {
        //Begin32
        Console.WriteLine("Введите температуру по Цельсию:");
        double Tc = Convert.ToDouble(Console.ReadLine());
        double Tf = Tc * 9 / 5 + 32;
        Console.WriteLine(Tf);



        //Integer12
        Console.WriteLine("Введите трехзначное число:");
        string digit =Console.ReadLine();
        for (int i = digit.Length - 1; i!=-1; i--)
        {
            Console.Write(digit[i]);
        }


        //Boolean34

        Console.WriteLine("Напишите координаты шахматной доски х у через пробел");
        string[] coordinates = Console.ReadLine().Split();
        int sum = 0;
        foreach(string c in coordinates)
        {
            sum+=Convert.ToInt32(c);
        }
        if (sum % 2 == 0) Console.WriteLine("Поле черное!");
        else {
            Console.WriteLine("Поле белое!");
        }


    }
}