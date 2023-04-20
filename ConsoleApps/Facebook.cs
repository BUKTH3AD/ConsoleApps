using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    internal class Facebook
    {
        internal static void Likes()
        {
            string? input = default;
            List<string> likes = new List<string>();
            while (true)
            {
                Console.WriteLine("Введите имя");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                likes.Add(input);
            
            }
            switch (likes.Count)
            {
                case 0:
                    Console.WriteLine("No one likes your post.");
                    break;
                case 1:
                    Console.WriteLine($"{likes[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
                    break;
                default:
                    Console.WriteLine($"{likes[0]}, {likes[1]} and {likes.Count - 2} others like your post.");
                    break;

            }

        }
    }
}
