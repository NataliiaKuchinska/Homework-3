using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Task1(int a, int b)
        {
            int res;
            if (a > b)
            {
                res = a + b;
            }
            else if (a == b)
            {
                res = a * b;
            }
            else
            {
                res = a - b;
            }
            return res;
        }
        static int Task2(int x, int y)
        {
            int res;
            if (x * y > 0)
            {
                if (x > 0)
                {
                    res = 1;
                }
                else
                {
                    res = 3;
                }
            }
            else if (x * y < 0)
            {
                if (x > 0)
                {
                    res = 4;
                }
                else
                {
                    res = 2;
                }
            }
            else
            {
                res = 0;
            }
            return res;
        }
        static (int, int, int) Task3(int a, int b, int c)
        {
            if (a > b)
            {
                a = a ^ b;
                b = a ^ b;
                a = a ^ b;
            }
            if (b > c)
            {
                if (a > c)
                {
                    a = a ^ b;
                    b = a ^ b;
                    a = a ^ b;
                    a = a ^ c;
                    c = a ^ c;
                    a = a ^ c;
                }
                else
                {
                    b = b ^ c;
                    c = b ^ c;
                    b = b ^ c;
                }
            }
            return (a, b, c);
        }
        static (double, double) Task4(double a, double b, double c)
        {
            double x1, x2;
            double d = a * a - (4 * a * c);
            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else if (d > 0)
            {
                d = Math.Sqrt(d);
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
            }
            else
            {
                x1 = Double.NaN;
                x2 = Double.NaN;
            }
            return (x1, x2);
        }
        static string Task5(int number)
        {
            string[] units ={ " ", "one","two","three","four", "five","six", "seven","eight","nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen","nineteen"};
            string[] dozens = { "twenty", "thrirty", "fourty", "fifty", "sixty", "seventy", "eightty", "ninety" };
            if (number < 20)
            {
                return units[number];
            }
            else
            {
                return dozens[-2 + number / 10] + " " + units[number % 10];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Task5(22));
        }
    }
}
