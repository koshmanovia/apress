using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car MyCar = new Car("Zippy", 20);
            MyCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    MyCar.Accelerate(23);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error ***"); // ошибка
                Console.WriteLine("Method: {0}" , e.TargetSite); // метод
                Console.WriteLine("Message: {0} ", e.Message); // сообщение
                Console.WriteLine("Source: {0}" , e.Source);
            }
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
            Console.ReadLine();
        }
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
                    throw new Exception($"{PetName} has overheated!");
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0} KMH", CurrentSpeed);
            }
        }
    }
}
