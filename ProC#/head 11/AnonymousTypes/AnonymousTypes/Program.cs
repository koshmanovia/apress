using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Anonymous Types *****");
            //Создать анонимный тип представляющий автомобиль
            var MyCar = new { Color = "Bring Pink", Make = "Saab", CurrentSpeed = 55 };
            Console.WriteLine("MyCar is {0} {1}", MyCar.Color, MyCar.Make);
            //Теперь вызовим вспомогательный метод для постороения 
            //Анонимного типа с указанием аргументов.
            BuildAnonType("BMW", "Black", 90);
            ReflectOverAnonymousType(MyCar);
            Console.ReadLine();
        }
        static void BuildAnonType(string make, string color, int currSp)
        {
            // Построить анонимный тип с применением входных аргументов,
            var car = new { Make = make, Color = color, Speed = currSp };
            // Обратите внимание, что теперь этот тип можно
            // использовать для получения данных свойств!
            Console.WriteLine("You have a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);
            // Анонимные типы имеют специальные реализации каждого
            // виртуального метода System.Object. Например:
            Console.WriteLine("ToString () == {0}", car.ToString());
        }
        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj .ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }
    }
}
