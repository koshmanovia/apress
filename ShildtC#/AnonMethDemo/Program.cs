using System;
delegate void CountIt();
class AnonMethDemo
{
    static void Main(string[] args)
    {
        // Далее следует код для подсчета чисел, передаваемый делегату
        // в качестве анонимного метода.
        CountIt count = 
            delegate
            {
                // Этот кодовый блок передается делегату.
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            }; // обратите внимание на точку с запятой
        //Так же для удобства код можно записать так
        //CountIt count1 = delegate { for (int i = 0; i <= 5; i++) { Console.WriteLine(i); } }; 
        count();
        Console.ReadLine();
    }
    
}

