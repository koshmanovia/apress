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
            Console.WriteLine("***** Fun with System.GC *****");
            // Вывести оценочное количество байтов, выделенных в куче.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
            // Значения MaxGeneration начинаются c 0, поэтому при выводе добавить 1.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));
            Car refToMyCar = new Car("Zippy", 100);
            Console.WriteLine(refToMyCar.ToString());
            // Вывести поколение объекта refToMyCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
            Console.ReadLine();
        }
    }
}
