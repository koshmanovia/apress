using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person p1 = new Person();
            // Использовать унаследованные члены System.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());
            
            // Создать другие ссылки на pi.
            Person р2 = p1;
            object о = р2;
            // Указывают ли ссылки на один и тот же объект в памяти?
            if (о.Equals(p1) && р2.Equals(о))
            {
                Console.WriteLine("Same instance! ");
            }
            Console.ReadLine();
        }
    }
}
