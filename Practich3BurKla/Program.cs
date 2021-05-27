using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practich3BurKla
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                int sch = 0;
                int min = int.MaxValue;
                int[] massiv = new int[5] {10,-3,-5,2,5};               
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = Math.Abs(massiv[i]);
                    if (min > massiv[i])
                    {
                        min = massiv[i];
                        sch++;
                    }
                }
                Console.WriteLine("Минимальный элемент массива = " + min + "  Порядковый номер: " + sch);
            }
            //2
            {
                int[] massiv = { 1, 5, 2, 1, 2, 3 };
            string s = "";
            for (int i = 0; i < massiv.Length; i++)
            {
                bool b = false;
                for (int j = 0; j < massiv.Length; j++)
                {
                    if (massiv[i] == massiv[j] && i != j)
                    {
                        b = true;
                    }
                }
                if (!b)
                {
                    s += massiv[i] + " ";
                }
            }
            Console.WriteLine(s);
            }
            //3
            {
                int[] mas = new int[100];
                int i = 0;
                string test;
                int count = 0;
                Console.WriteLine("Введите числа массива: ");
                Console.WriteLine("Введите - end для завершения");
                do
                {
                    test = Console.ReadLine();
                    if (test == "end") 
                        break;
                    mas[i] = Convert.ToInt32(test);
                    i++; 
                    count++;
                } while (true);

                Console.WriteLine("Массив: ");
                for (int j = 0; j < mas.Length; j++)
                {
                    if (mas[j] != 0)
                    {
                        Console.Write("{0} ", mas[j]);
                    }
                }
                Console.WriteLine("\nМассив без отрицательных чисел = ");
                for (int j = 0; j < count; j++)
                {
                    
                    if (mas[j] > 0)
                    {
                        Console.Write(mas[j] + "  ");
                    }
                    
                }
                Console.ReadLine();
            }
        }
    }
}
