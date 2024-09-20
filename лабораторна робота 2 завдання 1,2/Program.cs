using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторна_робота_2_завдання_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //task 1
            double a = 4;
            double x;
            double y = 0;
            double e = 2.72;
            double pi = 3.14;
            Console.WriteLine("Input x");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 1.2)
            {
                y = Math.Pow(e, (Math.Pow(x, 2) / 2)) + Math.Log(a);
            }

            else if (x == 1.2)
                y = a * Math.Pow(Math.Cos((pi * x) / 2.7), 3);
            else if (x > 1.2)
                y = Math.Pow(x, 2) + a * x + 56;
            Console.WriteLine(y);


            //task 2
            double a1;
            double b;
            double c;
            Console.WriteLine("Input a1");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToDouble(Console.ReadLine());
            if (a1 + b > c && a1 + c > b && b + c > a1)
                if (a1 == b && b == c)
                {
                    Console.WriteLine("Трикутник рівносторонній");
                }
                else if (a1 == b || a1 == c || b == c)
                {
                    Console.WriteLine("Трикутник рівнобедрений");
                }
                else
                {
                    Console.WriteLine("Трикутник довільний");
                }
            else
            {
                Console.WriteLine("Трикутник не існує");
            }
            Console.ReadKey();
        }
    }
}
