using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Dexter", "System Shock 2" };
            QueryStringWithOperators(currentVideoGames);
            System.Console.WriteLine();
            QuerySttringWithEnumerableAndLambdas(currentVideoGames);
            Console.ReadLine();
        }

        static void QueryStringWithOperators(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Query Operators*****\n");
            var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        static void QuerySttringWithEnumerableAndLambdas(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****\n");
            //Построить выражение запроса с использование расширяемых методов,
            //Предоставленных типу Array  через тип Enumerable 
            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }
        }
    }
}
