using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            //Создаем объект car
            Car cl = new Car("SlugBug", 100, 10);
            //сообщаем car какой метод надо вызвать
            cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Console.WriteLine("***** Speeding пр *****");
            for (int i = 0; i < 6; i++)
            {
                cl.Accelerate(20);
            }             
            Console.ReadLine();
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}
