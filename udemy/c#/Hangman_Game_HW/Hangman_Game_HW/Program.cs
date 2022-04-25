using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = new Hangman();
            Console.WriteLine(h.numStrWord + "\n" + h.secretWord);
            h.StartGame();
            Console.ReadKey();
        }
    }
    public class Hangman
    {
        public int numStrWord = default;
        public string secretWord = default;
        int attempt = 6;
        char[] checkChar = default;

        public Hangman()
        {
            numStrWord = new Random().Next(1, 11650);
            numStrWord = 11650;
            secretWord = File.ReadLines("WordsStockRus.txt").Skip(numStrWord - 1).First();
            checkChar = new char[secretWord.Length];        
        }

        public void StartGame()
        {
            string tempChar = default;
            for (; attempt > 0; attempt--)
            {
                Console.WriteLine("Загаданное слово:\n");
                //Console.WriteLine(new String('*', secretWord.Length));
                OutputSecretWord();
                Console.WriteLine("\nВведите букву");
                Console.ReadLine();

            }
        }
        public void OutputSecretWord()
        {
            checkChar[1] = 'а';
            checkChar[4] = 'а';
            for (int i = 0; i < secretWord.Length; i++)
            {
                for (int j = 0; j < checkChar.Length; j++)
                {
                    if (secretWord[i] == checkChar[j] && i == j)
                    {
                        Console.Write(secretWord[i]);
                    } else
                        if(i == j && secretWord[i] != checkChar[j])
                        {
                        Console.Write("*");
                        }
                }
            }
        }
    }
}

