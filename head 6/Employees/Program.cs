﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();
            chucky.GiveBonus(11556);
            chucky.Displaystats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(3124);
            fran.Displaystats();

            Console.ReadLine();
        }
    }
}
