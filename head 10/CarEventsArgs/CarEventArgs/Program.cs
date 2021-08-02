using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEventsArgs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if(sender is Car c)
            {

            }
            Console.WriteLine($"{sender} says: {e.msg}");
        }
    }
}
