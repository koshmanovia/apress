using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods: ***** \n");
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Add(x, y, out int ans);
            Console.WriteLine("Answer is: {0}", ans);
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            int i = default;
            string s = default;
            bool b = default;
            //FillTheseValues(out i,out s, out b);
            FillTheseValues(out _, out _, out _); //пример с отбрасыванием вывода
            Console.WriteLine("\nInt is: {0}\nString is: {1}\nbool is: {2}", i, s, b);
          
            string strl = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", strl, str2);
            SwapStrings(ref strl, ref str2);
            Console.WriteLine("After: {0}, {1} \n", strl, str2);

            #region Ref locals and params
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            ref var refoutput = ref SimpleRefReturn(stringArray, pos);
            refoutput = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            #endregion

            Console.ReadLine();
        }
        static void Add(int x, int y, out int sum)
        {
            sum = x + y;
            // Вызывающий код не увидит эти изменения,
            // т.к. модифицируется копия исходных данных,
            x = 10000;
            y = 88888;
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        public static ref string SimpleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }
    }
}
