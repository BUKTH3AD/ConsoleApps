using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseNames
    {
        internal static void Start()
        {
            Console.WriteLine("Введите имя");
            string input = Console.ReadLine();
            char[] output = new char[input.Length];
            for (int i = 0 ;i < input.Length; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }
            foreach (var item in output)
            {
                Console.Write(item);
            }
            
        }
    }
}
