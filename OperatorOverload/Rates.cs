using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Rates
    {
        static Rate[] rates;

        public Rates()
        {
            rates = new Rate[0];
        }

        public void AddRate(Rate rate)
        {
            int length = rates.Length;
            Array.Resize(ref rates, length + 1);
            rates[length] = rate;
        }

        public static double FindByValute(string valute)
        {
            for (int i = rates.Length - 1; i >=0 ; i--)
            {
                if (valute == rates[i].Valute1)
                    return rates[i].CurrentRate;
            }
            return -1;
        }

        override public string ToString()
        {
            string result = "";
            for (int i = 0; i < rates.Length; i++)
                result += rates[i].ToString() + "\n";

            return result;
        }
    }
}
