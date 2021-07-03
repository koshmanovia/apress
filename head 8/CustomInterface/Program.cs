using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Обратиться к свойству Points, определенному в интерфейсе IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            // Перехватить возможное исключение InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy ltfPt = null;
            try
            {
                ltfPt = (IPointy)c;
                Console.WriteLine(ltfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
