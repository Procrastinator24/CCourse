using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    

    static void Main()
    {
        /*//Begin32
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

        //If12
        Console.WriteLine("Введите 3 числа:");
        var arr = Console.ReadLine().Split(' ');
        List<int> numbers = new List<int>();
        foreach(string s in arr)
        {
            numbers.Add(Convert.ToInt32(s));

        }
        numbers.Sort();
        Console.WriteLine(numbers[0]);

        // case1
        Console.WriteLine("Напишите число от 1 до 7");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
        }
*/
        //for
        Console.WriteLine("Напишите числа А и B");
        int[] AB = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

        for(int a = AB[0]; a <= AB[1]; a++)
        {
            Console.Write(a*a + " ");
        }

    }
}