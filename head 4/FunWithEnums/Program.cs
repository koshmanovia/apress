using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        enum EmpType : byte
        {
            Manager = 10,       //=0, если задать значение 200, то след значения будут 200+1
            Grunt = 1 ,         //=1, 201
            Contractor = 100,    //=2, 202
            VicePresident =255  //=3, 203
        }
        static void Main()
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Создать переменную типа ЕтрТуре.
            EmpType еmр = EmpType.Manager;
            AskForBonus(еmр);
            Console.ReadLine();
        }
        // Перечисления как параметры,
        static void AskForBonus(EmpType е)
        {
            switch (е)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    //He желаете ли взамен фондовые опционы?
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    // Вы должно быть шутите. . .
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    // Вы уже получаете вполне достаточно...
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    // Очень хорошо, сэр!
                    break;
            }
        }
    }
}
