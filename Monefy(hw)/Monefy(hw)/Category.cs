using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    public enum Type
    {
        Income,
        Outcome
    }
    class Category
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public Category(string name, Type type)
        {
            Name = name;
            type = Type;
        }
    }
}
