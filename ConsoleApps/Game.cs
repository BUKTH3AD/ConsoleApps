using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    {
        internal static void Start()
        {
            bool isExitTyped = false;

            while (!isExitTyped)
            {
                bool isCorrectNumber = false;
                int attempts = 10;
                int rndNum = new Random().Next(1, 10);
                Console.WriteLine($"Угадай число от 1 до 10. Количество попыток: {attempts}");
                while (attempts > 0 && !isCorrectNumber)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int number))
                    {
                        if (number != rndNum)
                        {
                            attempts--;
                            Console.WriteLine($"Не верно. Количество попыток: {attempts}");
                        }
                        else
                        {
                            isCorrectNumber = true;

                            break;
                        }


                    }
                    else if (input.ToLower() == "exit")
                    {
                        isExitTyped = true;
                    }
                    else
                    {
                        Console.WriteLine("Не могу распознать ввод");
                    }

                }
                if (isCorrectNumber)
                    Console.WriteLine($"Вы угадали, это число {rndNum}");
                else
                    Console.WriteLine("Игра окончена. Попробуйте ещё раз.");


            }
        }
    }
}
