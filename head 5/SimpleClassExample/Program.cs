using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Разместить в памяти и сконфигурировать объект Саг.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            // Увеличить скорость автомобиля в несколько раз и вывести новое состояние,
            for (int i = 0; i <= 10; i++)
            {
                myCar.Speedup(13);
                myCar.PrintState();
            }
            // Вызов стандартного конструктора.
            Car chuck = new Car();
            chuck.PrintState();

            // Создать объект Car по имени Mary co скоростью 0 миль в час.
            Car тагу = new Car("Mary");
            тагу.PrintState();
            // Создать объект Car по имени Daisy со скоростью 75 миль в час.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely(); 

            Console.ReadLine();
        }
    }
}
