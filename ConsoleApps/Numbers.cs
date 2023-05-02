using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    internal class Numbers
    {
        internal static void Unique()
        {
            
            int[] numbers = new int[5]; 
            Console.WriteLine("Введите 5 уникальных числа");
            for (int i = 0; i < 5; i++)
            {

                int input = default;
                input = int.Parse(Console.ReadLine());

                while (numbers.Contains(input))
                {
                    Console.WriteLine("Такое число уже было");
                    input = int.Parse(Console.ReadLine());
                }
                numbers[i] = input;

                
            }
            Array.Sort(numbers);
            foreach (int number in numbers)
            { Console.Write($"{number} "); }
            
        }
        internal static void AllNumbers() 
        {
            Console.WriteLine("Please enter numbers or type \"Quit\" for exit");
            List<int> nums = new List<int>();
            string input = Console.ReadLine();
            while (input.ToLower() != "quit")
            {

            }
            nums.Add(int.Parse(Console.ReadLine()));
        }
    }
}
