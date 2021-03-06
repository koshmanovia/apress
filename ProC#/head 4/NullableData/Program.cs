using MaxMind.GeoIP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NullableData
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("***** Fun with Nullable Data *****\n");
                DatabaseReader dr = new DatabaseReader();

                // Get int from "database".
                int? i = dr.GetIntFromDatabase();
                if (i.HasValue)
                    Console.WriteLine("Value of 'i' is: {0}", i.Value);
                else
                    Console.WriteLine("Value of 'i' is undefined.");

                // Get bool from "database".
                bool? b = dr.GetBoolFromDatabase();
                if (b != null)
                    Console.WriteLine("Value of 'b' is: {0}", b.Value);
                else
                    Console.WriteLine("Value of 'b' is undefined.");

                // If the value from GetIntFromDatabase() is null,
                // assign local variable to 100.
                int myData = dr.GetIntFromDatabase() ?? 100;
                Console.WriteLine("Value of myData: {0}", myData);

                // Long hand version of using ? : ?? syntax.
                int? moreData = dr.GetIntFromDatabase();
                if (!moreData.HasValue)
                    moreData = 100;
                Console.WriteLine("Value of moreData: {0}", moreData);

                TesterMethod(null);

                Console.ReadLine();
        }
        static void TesterMethod(string[] args)
        {
            // We should check for null before accessing the array data!
            Console.WriteLine($"You sent me {args.Length} arguments.");
        }
    }
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }

        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
}

