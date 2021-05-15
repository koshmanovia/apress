﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunForArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** FunwithArrays *****");
            SimpleArrays();            
            Arraylnitialization();
            DeclarelmplicitArrays();
            ArrayOfObjects();

            Console.ReadLine();
        }
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Создать массив int, содержащий 3 элемента с индексами 0, 1, 2.
            int[] mylnts = new int[3];
            // Создать массив string, содержащий 100 элементов с индексами 0-99.
            int iterator = 0;
            string[] booksOnDotNet = new string[100];
            int[] myInts = new int[3];
            mylnts[0] = 100;
            mylnts[1] = 200;
            mylnts[2] = 300;
            // Вывести все значения.
            foreach (int i in mylnts)
            { 
                Console.WriteLine(i); 
            }
            Console.WriteLine();
        }
        static void Arraylnitialization()
        {
            Console.WriteLine("=> Array Initialization.");
            // Синтаксис инициализации массива с использованием ключевого слова new.
            string[] stringArray = new string[]{ "one", "two", "three", "four"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            
            // Синтаксис инициализации массива без использования ключевого слова new.
            bool[] boolArray = { false, false, true, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            
            // Инициализация массива с применением ключевого слова new и указанием размера.
            int[] intArray = new int[5] {4,4,4,4,4};
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        static void DeclarelmplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // Переменная а на самом деле имеет тип int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            // Переменная b на самом деле имеет тип double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            // Переменная с на самом деле имеет тип string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            /*
             *  Данный код не запустится, так как неявное типизирование 
             *  подразумевает однотипность передаваемых данных
             *  var d = new[] { 1, "one", 2, "two", false };
             */
            Console.WriteLine();
        }
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            // Массив объектов может содержать все что угодно,
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Вывести тип и значение каждого элемента в массиве.
                Console.WriteLine("Туре: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }
    }
}
