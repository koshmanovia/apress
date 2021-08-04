using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLamdaExpressions
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****");
            TraditionalDelegateSyntax();
            Console.ReadLine();
        }
        static void TraditionalDelegateSyntax()
        {
            //Создать список целочисленных значений.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44, 33, 22, 453 });
            //Вызвать FindAll() с применением традиционного синтаксиса делегатов
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t",evenNumber);
            }
        }
        //Метод класса System.Collections.Generic.List<T>.
        static public bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
        /*public List<T> FindAll(Predicate<T> match)
        {
            
        }*/
    }
}
