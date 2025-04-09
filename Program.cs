using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    public static bool IsWhite(string[] coordinates)
    {
        int sum = 0;
        foreach (string c in coordinates)
        {
            sum += Convert.ToInt32(c);
        }
        if (sum % 2 == 0) return false;
        else
        {
            return true;
        }
    }

    public static string Reverse(string some)
    {
        string res = "";
        for (int i = some.Length - 1; i != -1; i--)
        {
            res += some[i];
        }
        return res;
    }

    static void Main()
    {
        //Begin32
        Console.WriteLine("Введите температуру по Цельсию:");
        double Tc = Convert.ToDouble(Console.ReadLine());
        double Tf = Tc * 9 / 5 + 32;
        Console.WriteLine(Tf);


        //Integer12
        Console.WriteLine("Введите трехзначное число:");
        Console.WriteLine(Reverse(Console.ReadLine())); 
        


        //Boolean34

        Console.WriteLine("Напишите координаты шахматной доски х у через пробел");
        string[] coordinates = Console.ReadLine().Split();
        Console.WriteLine(IsWhite(coordinates)? "Черное":"Белое");
       

        //If12
        Console.WriteLine("Введите 3 числа:");
        var arr = Console.ReadLine().Split(' ');
        
        Console.WriteLine(min(arr));

        // case1
        Console.WriteLine("Напишите число от 1 до 7");
        Convert.ToInt32(Console.ReadLine());

        //for
        Console.WriteLine("Напишите числа А и B");
        int[] AB = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
        Sqrts(AB);

        


        //while15
       
        Console.WriteLine("(0 < P < 25) P = ");
        int p = Convert.ToInt32(Console.Read());
        Console.WriteLine("Прошло " + MonthsPassed(p) + " месяцев");

        Proc();
        Console.WriteLine("Введите 10 чисел");
        double[] doubles = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).ToArray();
        Console.WriteLine(SumM(doubles));

    }

    static public int min(string[] arr)
    {
        List<int> numbers = new List<int>();
        foreach (string s in arr)
        {
            numbers.Add(Convert.ToInt32(s));
        }
        numbers.Sort();
        return numbers[0];
    }

    static public string Day(int d)
    {
        switch (d<=7? d:d%7)
        {
            case 1:
                return "Понедельник"; break;
            case 2:
                return "Вторник"; break;
            case 3:
                return "Среда"; break;
            case 4:
                return "Четверг"; break;
            case 5:
                return "Пятница"; break;
            case 6:
                return "Суббота"; break;
            case 7:
                return "Воскресенье";
                break;
            default:
                return "Nothing";
        }
        

    }

    static public void Sqrts(int[] arr)
    {
        for (int a = arr[0]; a <= arr[1]; a++)
        {
            Console.Write(a * a + " | ");
        }
        Console.WriteLine();
    }

    static public int MonthsPassed(int percent)
    {
        int start = 1000;
        int months = 0;
        while (start <= 1100)
        {
            start += start * percent / 100;
            months += 1;
        }
        return months;
    }


    static public double SumM(double[] doubles)
    {
        return doubles.Sum(x => x);
    }

    static public void Proc()
    {
        //Proc16
        Console.WriteLine("Введите А и В");
        double[] XY = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).ToArray();
        Console.WriteLine(Sign(XY[0]) + Sign(XY[1]));
    }

    static int Sign(double x)
    {
        if (x < 0){return -1;}
        else if (x > 1) { return 1; }
        return 0;
    }
}