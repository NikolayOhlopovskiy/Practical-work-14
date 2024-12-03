using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._1
{
    internal class Program
    {
        /// <summary>
        /// Заполнить одномерный массив.Вывести его в консоль.
        /// </summary>
        /// <param name="args"></param>
        static int Size()
        {
            Console.Write("Размер одномерного массива :");
            int size;
            while(!int .TryParse(Console.ReadLine(),out size) || size<=0)
            {
                Console.WriteLine("Ошибка");
                
            }
            return size;
            
        }
        static int[] Input(int size)
        {
            int[]omas = new int[size];
            Console.WriteLine("Заполнить одномерный массив");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"omas[{i}]");
                omas[i] =Convert.ToInt32(Console.ReadLine());
            }
            
                return omas;
       
        }
        static void  Output(int size)
        {
            Console.WriteLine("Вывести одномерный массив");
            for(int i = 0;i< size;i++)
            {
                Console.Write($"omas[{i}]=omas[{i}]");
               
            }
           
            
        }
        static void Main(string[] args)
        {
            int size=Size();
            int[]omas= Input(size);
            Output(size);
            Console.Read();
        }
    }
}
