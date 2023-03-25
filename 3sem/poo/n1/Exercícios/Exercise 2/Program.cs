using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>() { };
            string go_foward = "N";
            do
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

                Console.WriteLine("Want to continue adding games? [Y]/[N]\nSpaces left: " + (10-games.Count) );
                go_foward = Console.ReadLine().ToUpper();
                games.Add(game);
            }
            while (games.Count <= 10 && go_foward == "Y");
            Console.Clear();

            foreach (Game game in games)
            {
                Console.WriteLine("\nGame info:\n");
                Console.WriteLine(game.GetCode());
                Console.WriteLine(game.GetName());
                Console.WriteLine(game.GetCategory());
                Console.WriteLine(game.GetReleaseDate());
            }

            Console.ReadKey();

        } 
    }
}
