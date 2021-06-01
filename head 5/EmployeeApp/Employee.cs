﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        // Конструкторы.
        
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        // Методы.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void Displaystats()
        {
            Console.WriteLine("Name: {0}", empName); // имя сотрудника
            Console.WriteLine("ID: {0}", empID); // идентификационный номер сотрудника
            Console.WriteLine("Pay: {0}", currPay); // текущая выплата
        }
        // Метод доступа (метод get) .
        public string GetName()
        {
            return empName;
        }
        // Метод изменения (метод set) .
        public void SetName(string name)
        {
            // Перед присваиванием проверить входное значение,
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            // Ошибка' Длина имени превышает 15 символов!
            else
                empName = name;
        }
    }
}

