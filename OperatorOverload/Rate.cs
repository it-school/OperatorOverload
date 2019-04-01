using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Rate
    {
        DateTime date;
        string valute1;
        string valute2;
        double currentRate;

        public DateTime Date { get => date; set => date = value; }
        public string Valute1 { get => valute1; set => valute1 = value; }
        public string Valute2 { get => valute2; set => valute2 = value; }
        public double CurrentRate { get => currentRate; set => currentRate = value; }

        public Rate(DateTime date, string valute1, string valute2, double currentRate)
        {
            Date = date;
            Valute1 = valute1;
            Valute2 = valute2;
            CurrentRate = currentRate;
        }

        public override string ToString()
        {
            return $"{date.ToShortDateString()}: 1 {valute1} in {valute2} : {currentRate}";
        }
    }
}
