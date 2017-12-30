using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    enum Currency
    {
        Azn,
        Usd,
        Eur
    }

    class Account : ICSVWritable, IConsoleWritable, IComparable
    {
        public string Name { get; set; }
        public Currency Currency { get; set; }
        public double Money { get; set;}
        public bool Hidden { get; set; }
        public Account(string accName, Currency currency, double accMoney, bool accHidden = false)
        {
            Name = accName;
            this.Currency = currency;
            Money = accMoney;
            Hidden = accHidden;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void CSVWrite()
        {
            throw new NotImplementedException();
        }

        public void ConsoleWrite()
        {
            throw new NotImplementedException();
        }

        public bool Hiddent { get; set; }
    }
}
