using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Data type Functionality: ");

            Console.WriteLine("max of int = {0}", int.MaxValue);
            Console.WriteLine("min of int = {0}", int.MinValue);

            Console.WriteLine("max of double = {0}", double.MaxValue);
            Console.WriteLine("min of double = {0}", double.MinValue);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.ReadLine();
        }
    }
}
