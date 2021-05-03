using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringfunctionality();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            Console.ReadLine();
        }
        static void BasicStringfunctionality()
        {
            Console.WriteLine("=> Basic String functionality:\n");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}",firstName);//значение firstName
            Console.WriteLine("firstName has {0} characters.", firstName.Length);//длина симвролов firstName
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());//firstName в верхнем регистре
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());//firstName в нижнем регистре
            Console.WriteLine("firstName contains the letter \'y\': {0}", firstName.Contains("y"));//проверка на наличие буквы "y"
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("y","or"));//замена y на or            
        }
        static void StringConcatenation()
        {
            Console.WriteLine("\n=> String Concatenation:\n");
            string s1 = "Programming the ";
            string s2 = "psyhodrill (ptp)";
            string s3 = String.Concat(s1, s2.ToUpper());//тоже самое что и s1 + s2.ToUpper()
            Console.WriteLine(s3);
        }
        static void EscapeChars()
        {
            string myLongString = @"This is a very 
            very 
               very 
                  long string";
            Console.WriteLine("\n=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPetName\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World!\"\a");
            Console.WriteLine(@"c:\myApp\bin\Debug"); //дословный вывод строки, не работают спецсимволы
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrrr! Pret-ty sun-sets""");
            Console.WriteLine("All Finished.\n\n\n\a\n");
        }
        static void StringEquality()
        {
            Console.WriteLine("\n=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            //Проверка строк на равенства
            Console.WriteLine("s1 ==s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}","Yo!".Equals(s2));
            Console.WriteLine();
        }
    
    }
}
