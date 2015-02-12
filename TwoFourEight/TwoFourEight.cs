using System;

class TwoFourEight
{
    static void Main()
    {
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong result = 0;

        if (b == 2)
        {
            result = a % c;
        }
        if (b == 4)
        {
            result = a + c;
        }
        if (b == 8)
        {
            result = a * c;
        }

        ulong remainder = 0;

        if (result % 4 == 0)
        {
            remainder = result / 4;
            Console.WriteLine(remainder);
        }
        else
        {
            remainder = result % 4;
            Console.WriteLine(remainder);
        }
<<<<<<< HEAD
        Console.WriteLine(result);
        Console.WriteLine("Different");
        
>>>>>>> a25b19e594ff95d7c8c621b9122b79e0178cd032
    }
}

