using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discret_2
{
    class Program
    {
        static void Pfun (bool[] mark, int[] r, int[] a, int n, int i, ref int cur)
        {
            if (i==n)
            {
                Console.WriteLine("[{0}]",cur);
                for (int j=0; j<n; j++)
                    Console.WriteLine("{0}", r[j]);
                cur++;
            }else
                for(int k=0; k<n; k++)
                {
                    if (mark[k]==false)
                    {
                        r[i] = a[k];
                        mark[k] = true;
                        Pfun(mark, r, a, n, i + 1,ref cur);
                        mark[k] = false;
                    }
                }
        }
        static void Main(string[] args)
        {
            unsafe
            {
                int n, k;
                Console.WriteLine("Мощность множества:");
                n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = i;
                Console.WriteLine("Кол-во символов:");
                k = Convert.ToInt32(Console.ReadLine());
                int[] raz = new int[n];
                ref int[] r = ref raz;
                bool[] flag = new bool[n];
                ref bool[] mark = ref flag;
                for (int i = 0; i < n; i++)
                    mark[i] = false;
                int j = 0, cur = 0;
                Pfun(mark, r, a, n, j, ref cur);
            }
        }
    }
}
