using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC Basics *****") ;
            Car refToMyCar = new Car("Zippy", 50);
            Console.WriteLine(refToMyCar.ToString());
            Console.ReadLine();
        }

    }
}
