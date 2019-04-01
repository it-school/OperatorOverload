using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Money moneyUSD = new Money();
            moneyUSD.Amount = 100;
            moneyUSD.Type = valuteType.USD;
            Console.WriteLine(moneyUSD);

            moneyUSD.AddMoney(new Money(100, valuteType.USD));
            Console.WriteLine(moneyUSD);
            moneyUSD = moneyUSD + moneyUSD;
            Console.WriteLine(moneyUSD);

            Rates rates = new Rates();
            rates.AddRate(new Rate(DateTime.Now, "HRN", "USD", 0.038));
            rates.AddRate(new Rate(new DateTime(2019, 3, 31), "USD", "HRN", 27.35));
            rates.AddRate(new Rate(DateTime.Now, "USD", "HRN", 27.38));
            rates.AddRate(new Rate(DateTime.Now, "EUR", "HRN", 31));
            rates.AddRate(new Rate(DateTime.Now, "HRN", "EUR", 0.033));

            Console.WriteLine(rates);

            Console.WriteLine(Rates.FindByValute("USD"));

            Money moneyHRN = new Money(10000, valuteType.HRN);
            moneyHRN = moneyHRN + moneyUSD;
            Money moneyEUR = new Money(100, valuteType.EUR);
            Console.WriteLine(moneyHRN);
            moneyHRN = moneyHRN + moneyEUR;
            Console.WriteLine(moneyHRN);

            Money m1 = new Money(100, valuteType.EUR);
            Money m2 = new Money(3100, valuteType.HRN);
            Console.WriteLine(m2 == m1);
        }
    }
}
