using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        //данные уровня экземпляра
        public double currBalance;
        //Статический эллемент
        public static double currlnterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        // Статические члены для установки/получения процентной ставки,
        public static void SetlnterestRate(double newRate) => currlnterestRate = newRate;
        public static double GetlnterestRate() { return currlnterestRate; }
    }
}
