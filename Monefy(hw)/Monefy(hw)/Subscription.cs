using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    enum SubscriptionType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
    class Subscription : ICSVWritable, IConsoleWritable, IComparable
    {
        public string Name { get; set; }
        public double Amount { get; set; }


        public DateTime StartDate{get; private set;}
        public DateTime EndDate { get; private set;}
        public SubscriptionType subType { get; private set;}
        public Subscription(string subName, double subAmount, DateTime subStartDate, DateTime subEndDate, SubscriptionType subType)
        {
            Name = subName;
            Amount = subAmount;
            StartDate = subStartDate;
            EndDate = subEndDate;
            this.subType = subType;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void ConsoleWrite()
        {
            
        }

        public void CSVWrite()
        {
            throw new NotImplementedException();
        }
    }
}
