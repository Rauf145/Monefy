using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    sealed class Application
    {
        private static Application obj;
        public int selectedAccount = -1;
        List<MoneyOperation> Incomes = new List<MoneyOperation>();
        List<MoneyOperation> Outcomes = new List<MoneyOperation>();
        public List<Account> Account = new List<Account>();
        List<Category> Categories = new List<Category>();
        List<Subscription> Subscriptions;
        private Application()
        {

        }

        public static Application GetObj()
        {
            if (obj == null)
            {
                obj = new Application();
            }
            return obj;
        }

        public void CreateAccount(string name, Currency currency, double money, bool hidden = false)
        {
            Account.Add(new Account(name, currency, money, hidden));
        }

        public void CreateOperation(string category, double amount, string note, int type)
        {
            int index = FindCategory(category, type);
            if (type == 1)
            {
                Outcomes.Add(new MoneyOperation(amount, Categories[index], note));
                Account[selectedAccount].Money -= amount;
            }
        }

        public void Statistics()
        {
            for (int i = 0; i < Incomes.Count; i++)
                Console.WriteLine(Incomes[i].category.Name + " " + Incomes[i].Amount);
            for (int i = 0; i < Outcomes.Count; i++)
                Console.WriteLine(Outcomes[i].category.Name + " " + Outcomes[i].Amount);
        }

        private int FindCategory(string category, int type)
        {
            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].Name == category && Categories[i].Type == (Type)type)
                    return i;
                else if (i == Categories.Count - 1)
                {
                    Categories.Add(new Category(category, (Type)type));
                    return Categories.Count - 1;
                }
            }
            if (Categories.Count == 0)
            {
                Categories.Add(new Category(category, (Type)type));
                return Categories.Count - 1;
            }
            return 0;
        }

        public Account getAccount()
        {
            if (selectedAccount != -1 && selectedAccount < Account.Count)
                return Account[selectedAccount];
            return null;
        }

    }
}
