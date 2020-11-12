using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discret_4
{
    class Program
    {
        static void funBoolean(int[] ar, int n)
        {
            double k = Math.Pow(2, n);
            for (int i = 0; i < k; i++)
            {
                Console.Write("{");
                for (int j = 0; j < n; j++)
                    if ((i & (1 << j)) != 0)
                        Console.Write("{0} ", ar[j]);
                Console.Write("}\n");
            }
        }
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Введите мощность множества. Его элементы будут состоять из собственных номеров");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            for (i = 0; i < n; i++)
                ar[i] = i + 1;

            funBoolean(ar, n);
        }
    }
}