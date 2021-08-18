using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("sss.");
            //Int32 index = StringBuilderExtensions.IndexOf(sb.Replace(".", "!"), '!');
            Int32 index = sb.Replace(".", "!").
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
    public static class StringBuilderExtensions
    {
        public static Int32 IndexOf(this StringBuilder sb, Char value)
        {
            for (Int32 index = 0; index < sb.Length; index++)
                if (sb[index] == value) return index;
            return -1;
        }
    }
}
