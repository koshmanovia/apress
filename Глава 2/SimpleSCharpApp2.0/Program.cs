using System;
using System.Windows.Forms;

namespace SimpleCSharpApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "My Hacking App";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("***********************************");
            Console.WriteLine("*****Welcome to My Hacking App*****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            MessageBox.Show("All Done!");
        }
    }
}
