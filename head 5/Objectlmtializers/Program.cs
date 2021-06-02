using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            //Создать объект Point, устанавливая каждое свойство в ручную
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            //Создать объект Point посредством специального конструктора.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            //Создать объект Point, используя синтаксис  инициализации объектов.
            Point finalPoint = new Point {X=30,Y=30 };
            finalPoint.DisplayStats();
            Console.ReadLine();
        }
    }
}
