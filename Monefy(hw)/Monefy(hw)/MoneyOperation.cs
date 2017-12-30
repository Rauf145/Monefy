using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Monefy_hw_
{
    class MoneyOperation : ICSVWritable, IConsoleWritable, IComparable
    {
        public double Amount { get; set; }
        public Category category;
        public string Note { get; set; }
        public DateTime dateTime;//////
        public MoneyOperation(double amount, Category categ, string note)
        {
            Amount = amount;
            category = categ;
            Note = note;
            dateTime = DateTime.Now;
        }
        public int CompareTo(object obj)//////
        {
            throw new NotImplementedException();
        }//////

        public void CSVWrite()
        {
            string toCSV = "";
            string cat;
            if (category.Type == Type.Income)
                cat = "Income";
            else
                cat = "Outcome";
            toCSV += cat + ", ";
            toCSV += Amount.ToString() + ", ";
            toCSV += Note + ", ";
            toCSV += dateTime.ToString() + ", ";
        }

        public void ConsoleWrite()
        {
            throw new NotImplementedException();
        }
    }
}