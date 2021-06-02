using System;
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
        private int empAge;
        string empSSN;
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        //свойства
        public string Name
        {
            get => empName; 
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else { empName = value; }
            }
        }
        public int ID
        {
            get => empID; 
            set => empID = value;
        }
        public float Pay
        {
            get => currPay; 
            set => currPay = value;
        }
        public int Age
        {
            get => empAge; 
            set => empAge = value; 
        }

        // Конструкторы.
        public Employee() { }
        public Employee(string name, int id, float pay)
            :this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay,string ssn)
        {
            Name = name;
            Age = id;
            Pay = pay;
            Age = age;
            // Проверить надлежащим образом входной параметр ssn и затем установить значение.
            empSSN = ssn;
        }
        // Методы.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void Displaystats()
        {
            Console.WriteLine("Name: {0}", Name); // имя сотрудника
            Console.WriteLine("ID: {0}", ID); // идентификационный номер сотрудника
            Console.WriteLine("Age: {0}", Age); 
            Console.WriteLine("Pay: {0}", Pay);// текущая выплата
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
                Name = name;
        }
    }
}

