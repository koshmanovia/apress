using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFunctionality();
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
}
}
