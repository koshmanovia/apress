using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine();

            UseGenericStack();
            Console.WriteLine();

            UseGenericQueue();
            Console.WriteLine();

            Console.ReadLine();
        }
        static void UseGenericList()
        {
            //Создать список объектов Person и заполнить его с помощью
            //синтаксиса инициализации объектов и коллекции
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Homer", LastName="Simpson", Age=47},
                new Person { FirstName = "Marge", LastName="Simpson", Age=45},
                new Person { FirstName = "Lisa", LastName="Simpson", Age=9},
                new Person { FirstName = "Bart", LastName="Simpson", Age=8},               
            };
            //Выводим количество эллементов в списке
            Console.WriteLine("Items in List: {0}", people.Count);
            //перечисление в списке
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            //добавляем новый элемент в список
            Console.WriteLine("\n-> Inserting new Person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Item in list: {0}", people.Count);
            //копируем данные в новый массив
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in people)
            {
                Console.WriteLine($"First Nmaes: {p.FirstName}");
            }
        }
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            stackOfPeople.Push(new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });
            stackOfPeople.Push(new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            for (int i = stackOfPeople.Count; i >= 0; i--)
            {
                try
                {
                Console.WriteLine("\nfirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("\nError! {0}", ex.Message); // ошибка стек пуст
                }
            }   
        }
        static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee!");
        }
        static void UseGenericQueue()
        {
            //Создадим очередь
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            peopleQ.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });
            peopleQ.Enqueue(new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

            //возвращает первого в очереди
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            //Удаляем всех из очереди
            for (int i = peopleQ.Count; i > -1; i--)
            {
                try
                {
                    GetCoffee(peopleQ.Dequeue());
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine("Error! {0} ",ex.Message);
                }
            }
        }
    }
}
