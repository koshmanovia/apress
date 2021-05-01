using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFunctionality();
            DataTypeFunctionality();
            BoolFunctionality();
            CharFunctionality();
            ParseFromString();
            Console.ReadLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:\n");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("\n=> Data type Functionality:\n ");
            Console.WriteLine("max of int = {0}", int.MaxValue);
            Console.WriteLine("min of int = {0}", int.MinValue);
            Console.WriteLine("max of double = {0}", double.MaxValue);
            Console.WriteLine("min of double = {0}", double.MinValue);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

        }
        static void BoolFunctionality()
        {
            Console.WriteLine("\n=> bool data type:\n");
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
           
        }
        static void CharFunctionality()
        {
            Console.WriteLine("\n=> char data type:\n");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit(myChar): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter(myChar): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace(\"Hello There\", 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        }
        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing");
            bool b = bool.Parse("True");
            double d = double.Parse("99,884");
            int i = int.Parse("8");
            char c = char.Parse("w");
            Console.WriteLine("Value of b: {0}\nValue of d: {1}\nValue of i: {2}\nValue of c: {3}",b,d,i,c);
        }
    }
}
