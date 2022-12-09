using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int min;

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(-1);
            list.Add(4);
            list.Add(-1);

            void MIN(List<int> _list)
            {
                min = list.Min();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == min)
                    {
                        list[i] = x;
                        break;
                    }
                }

            }

            MIN(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}