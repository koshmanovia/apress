using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Отслеживать исключение.
                myCar.Accelerate(150);
            }
            catch (CarisDeadException e)
            { 
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.ReadLine();
        }
        class Radio
        {
            public void TurnOn(bool on)
            {
                Console.WriteLine(on ? "Jamming..." : "Quiet time...");

            }
        }
        class Car
        {
            // Константа максимальной скорости
            public const int MaxSpeed = 220;
            // свойства автомобиля
            public int CurrentSpeed { get; set; } = 0;
            public string PetName { get; set; } = "";

            // не вышел ли автомобиль из строя
            private bool carIsDead;

            // в автомобиле имеется радиоприемник
            private Radio theMusicBox = new Radio();

            // Конструкторы
            public Car() { }
            public Car(string name, int speed)
            {
                CurrentSpeed = speed;
                PetName = name;
            }

            public void CrankTunes(bool state)
            {
                // Делегировать запрос внутреннему объекту
                theMusicBox.TurnOn(state);
            }
            // Проверить не перегрелся ли автомобиль
            public void Accelerate(int delta)
            {
                if (carIsDead)
                    Console.WriteLine("{0} is out of order...", PetName);
                else
                {
                    CurrentSpeed += delta;
                    if (CurrentSpeed >= MaxSpeed)
                    {
                        carIsDead = true;
                        CurrentSpeed = 0;
                        CarisDeadException ex = new CarisDeadException($"{PetName} has overheated!",
                     "You have a lead foot", DateTime.Now);
                        ex.HelpLink = "http://www.CarsRUs.com";
                        throw ex;
                    }
                    else
                        Console.WriteLine("=> CurrentSpeed = {0} KMH", CurrentSpeed);
                }
            }
        }
    }
}
