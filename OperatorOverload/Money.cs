using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    enum valuteType
    {
        HRN,
        USD,
        EUR
    }

    class Money
    {
        double amount;
        valuteType type;

        public double Amount { get => amount; set => amount = value >= 0 ? value: 0; }
        internal valuteType Type { get => type; set => type = value; }

        public override string ToString()
        {
            return $"Im my wallet: {amount} {type}";
        }

        public void AddMoney(Money money)
        {
            this.amount += money.amount;
        }

        public Money(double amount, valuteType type)
        {
            Amount = amount;
            Type = type;
        }

        public Money()
        {
            this.type = valuteType.HRN;
            this.amount = 1;
        }

        public static Money operator +(Money m1, Money m2)
        {
            if (m1.type == m2.type)
                return new Money(m1.amount + m2.amount, m1.type);
            else
            {
                Array mas1 = valuteType.GetValues(typeof(valuteType));
             /*   foreach (valuteType name in mas1)
                    Console.WriteLine(name);
                    */

                double rate = Rates.FindByValute(mas1.GetValue((int)m2.type).ToString());
                return new Money(m1.amount + m2.amount*rate, m1.type);
            }
        }



        public static Money operator -(Money m1, Money m2)
        {
            if (m1.type == m2.type)
                return new Money(m1.amount - m2.amount, m1.type);
            else
            {
                Array mas1 = valuteType.GetValues(typeof(valuteType));
                double rate = Rates.FindByValute(mas1.GetValue((int)m2.type).ToString());
                return new Money(m1.amount - m2.amount * rate, m1.type);
            }
        }

        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.type == m2.type)
                return m1.amount == m2.amount ? true : false;
            else
            {
                Array mas1 = valuteType.GetValues(typeof(valuteType));
                double rate = Rates.FindByValute(mas1.GetValue((int)m2.type).ToString());

                Console.WriteLine(m1.amount);
                Console.WriteLine(m2.amount * rate);
                return m1.amount == m2.amount * rate ? true : false;
            }
        }

        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.type == m2.type)
                return m1.amount != m2.amount ? true : false;
            else
            {
                Array mas1 = valuteType.GetValues(typeof(valuteType));
                double rate = Rates.FindByValute(mas1.GetValue((int)m2.type).ToString());

                return m1.amount != m2.amount * rate ? true : false;
            }
        }
    }
}
