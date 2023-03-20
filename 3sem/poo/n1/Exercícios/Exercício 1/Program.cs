using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            do
            {
                try
                {
                    Console.WriteLine("Enter code: ");
                    game.SetCode(Convert.ToInt32(Console.ReadLine()));
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Enter name: ");
                    game.SetName(Console.ReadLine());
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Enter category: ");
                    game.SetCategory(Console.ReadLine());
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Enter release date: ");
                    game.SetReleaseDate(Convert.ToDateTime(Console.ReadLine()));
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (true);

            Console.WriteLine(
                $"Code: {game.GetCode()}\n" +
                $"Name: {game.GetName()}\n" +
                $"Category: {game.GetCategory()}\n" +
                $"Release date: {game.GetReleaseDate()}");
            Console.ReadKey();
        }
    }
}
