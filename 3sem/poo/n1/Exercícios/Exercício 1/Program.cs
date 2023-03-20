using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
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
                    Console.WriteLine("Code: ");
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
                    Console.WriteLine("Name: ");
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
                    Console.WriteLine("Category: ");
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
                    Console.WriteLine("Date: ");
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
