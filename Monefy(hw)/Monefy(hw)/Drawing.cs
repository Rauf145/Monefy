using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    class Drawing
    {
        public int selected { get; set; }
        public int choose { get; set; }
        public int menu { get; set; }
        private static Drawing obj;
        private Drawing()
        {
            menu = 0;
            selected = 3;
            choose = -1;
        }
        public static Drawing GetObj()
        {
            if (obj == null)
            {
                obj = new Drawing();
            }
            return obj;
        }

        public void DrawWindows()
        {
            if (menu == 2 && choose == 1)
            {
                DrawSettings("-+.txt", 12, 2);
                ShowAccs();
                choose = -1;
            }
            else if (menu == 2 && choose == 2)
            {
                
                Console.WriteLine(Text.getObj().selectedLanguage);
                if (Text.getObj().selectedLanguage == 0)
                    Text.getObj().selectedLanguage = 1;
                else
                    Text.getObj().selectedLanguage = 0;
                    //DrawSettings("-+.txt", 12, 2);
                    //ShowAccs();
                    choose = -1;
            }
            if (menu == 1 && choose == -1)
            {
                DrawSettings("tools.txt", 2, 1);
                DrawToolsFields();
            }
            else if (menu == 2 && choose == -1)
            {
                DrawSettings("settings.txt", 80);
                DrawSettingsFields();
            }
            else if (menu == 3 && choose == -1)
            {
                DrawSettings("-+.txt", 12, 2);
                Accrual();
            }
            else if (menu == 4 && choose == -1)
            {
                DrawSettings("-+.txt", 12, 2);
                Substract();
            }
            else if (menu == 5)
            {
                DrawSettings("-+.txt", 12, 2);
                CreatingAcc();
                menu = 0;
            }
            if (menu == 0)
            {
                Console.Clear();
                DrawFrame();
                DrawFields();
                Application.GetObj().Statistics();
            }
        }

        private void DrawFrame()
        {
            Console.SetCursorPosition(0, 0);
            string s = "";
            string tmp = "";
            using (StreamReader sr = File.OpenText("frame.txt"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    tmp += s + '\n';
                }
            }
            Console.WriteLine(tmp);
        }

        private void DrawSettings(string path, int x = 0, int y = 0)
        {
            string s = "";
            string[] tmp = new string[25];
            int j = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    tmp[j++] += s + '\n';
                }
            }
            j = 0;
            for (int i = y; i < tmp.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(tmp[j++]);
            }
        }

        private void DrawSettingsFields()  //временно
        {
            Console.SetCursorPosition(86, 7);
            Console.Write(Text.getObj()[2]);
            Console.SetCursorPosition(87, 10);
            Console.Write(Text.getObj()[0]);
            Console.SetCursorPosition(87, 13);
            Console.Write(Text.getObj()[22]);
            Console.SetCursorPosition(87, 16);
            Console.Write(Text.getObj()[3]);
            Console.ForegroundColor = ConsoleColor.Blue;
            if (selected == 0)
            {
                Console.SetCursorPosition(86, 7);
                Console.Write(Text.getObj()[2]);
            }
            else if (selected == 1)
            {
                Console.SetCursorPosition(87, 10);
                Console.Write(Text.getObj()[0]);
            }
            else if (selected == 2)
            {
                Console.SetCursorPosition(87, 13);
                Console.Write(Text.getObj()[22]);
            }
            else if (selected == 3)
            {
                Console.SetCursorPosition(87, 16);
                Console.Write(Text.getObj()[3]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private void DrawToolsFields() //временно
        {
            Console.SetCursorPosition(7, 7);
            Console.Write(Text.getObj()[9]);
            Console.SetCursorPosition(9, 10);
            Console.Write(Text.getObj()[8]);
            Console.SetCursorPosition(9, 13);
            Console.Write(Text.getObj()[4]);
            Console.SetCursorPosition(10, 16);
            Console.Write(Text.getObj()[5]);
            Console.ForegroundColor = ConsoleColor.Blue;
            if (selected == 0)
            {
                Console.SetCursorPosition(7, 7);
                Console.Write(Text.getObj()[9]);
            }
            else if (selected == 1)
            {
                Console.SetCursorPosition(9, 10);
                Console.Write(Text.getObj()[8]);
            }
            else if (selected == 2)
            {
                Console.SetCursorPosition(9, 13);
                Console.Write(Text.getObj()[4]);
            }
            else if (selected == 3)
            {
                Console.SetCursorPosition(10, 16);
                Console.Write(Text.getObj()[5]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private void DrawFields()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (selected == 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.SetCursorPosition(3, i);
                    Console.Write("───");
                }
            }
            else if (selected == 1)
            {
                Console.SetCursorPosition(69, 2);
                Console.Write(Text.getObj()[10]);
            }
            else if (selected == 2)
            {
                for (int i = 20; i < 23; i++)
                {
                    for (int j = 60; j < 65; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        if (j  == 62 && (i == 20 || i == 22))
                            Console.Write("│");
                        else if ((j == 60 || j == 61 || j == 63 || j == 64)&& i == 21)
                            Console.Write("─");
                        if(i == 21 && j == 62)
                            Console.Write("┼");
                    }
                }
            }
            else if(selected == 3)
            {
                Console.SetCursorPosition(9, 21);
                Console.Write("───────");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void CreatingAcc()
        {
            string name;
            Currency cur;
            double money;
            bool hidden;
            Console.SetCursorPosition(32, 4);
            Console.Write(Text.getObj()[11] + ": ");
            name = Console.ReadLine();
            Console.SetCursorPosition(32, 6);
            Console.Write(Text.getObj()[3] + ": ");
            switch (Console.ReadLine())
            {
                case "Azn":
                case "azn":
                    cur = Currency.Azn;
                    break;
                case "Usd":
                case "usd":
                    cur = Currency.Usd;
                    break;
                case "Eur":
                case "eur":
                    cur = Currency.Eur;
                    break;
                default:
                    cur = Currency.Usd;
                    break;
            }
            Console.SetCursorPosition(32, 8);
            Console.Write(Text.getObj()[23] + ": ");
            Double.TryParse(Console.ReadLine(), out money);
            Console.SetCursorPosition(32, 10);
            Console.Write(Text.getObj()[21] + "(" + Text.getObj()[20] +"/" + Text.getObj()[16] + "): ");
            switch (Console.ReadLine())
            {
                case "Yes":
                case "yes":
                case "y":
                case "Y":
                    hidden = true;
                    break;
                case "No":
                case "no":
                case "n":
                case "N":
                    hidden = false;
                    break;
                default:
                    hidden = false;
                    break;
            }
            Application.GetObj().CreateAccount(name, cur, money, hidden);
        }

        private void ShowAccs()
        {
            for (int i = 0; i < Application.GetObj().Account.Count; i++)
            {
                Console.SetCursorPosition(27, 4 + i);
                Console.Write(i + "." + Application.GetObj().Account[i].Name + " " + Application.GetObj().Account[i].Money + " " + Text.getObj()[21] + ": " + Application.GetObj().Account[i].Hidden);
                if (i == Application.GetObj().Account.Count - 1)
                {
                    Console.SetCursorPosition(32, 4 + i + 1);
                    Console.Write(Text.getObj()[6] + " " + Text.getObj()[7] + ": ");
                    Int32.TryParse(Console.ReadLine(), out Application.GetObj().selectedAccount);
                    if (Application.GetObj().selectedAccount >= Application.GetObj().Account.Count || Application.GetObj().selectedAccount < -1)
                        Application.GetObj().selectedAccount = -1;
                    menu = 0;
                }
            }

        }

        private void Substract()
        {
            string category = "";
            double amount = 0;
            string note = "";
            Console.SetCursorPosition(32, 4);
            Console.Write(Text.getObj()[2] + ": ");
            category = Console.ReadLine();
            Console.SetCursorPosition(32, 6);
            Console.Write(Text.getObj()[1] + ": ");
            Double.TryParse(Console.ReadLine(), out amount);
            Console.SetCursorPosition(32, 8);
            Console.Write(Text.getObj()[12] + ": ");
            note = Console.ReadLine();
            if (category != "" || amount <= Application.GetObj().Account[Application.GetObj().selectedAccount].Money)
            {
                Application.GetObj().CreateOperation(category, amount, note, 1);
            }
        }
        private void Accrual() //temperary
        {
            string category = "";
            double amount = 0;
            string note = "";
            Console.SetCursorPosition(32, 4);
            Console.Write(Text.getObj()[2] + ": ");
            category = Console.ReadLine();
            Console.SetCursorPosition(32, 6);
            Console.Write(Text.getObj()[1] + ": ");
            Double.TryParse(Console.ReadLine(), out amount);
            Console.SetCursorPosition(32, 8);
            Console.Write(Text.getObj()[12] + ": ");
            note = Console.ReadLine();
            if (category != "")
            {
                Application.GetObj().CreateOperation(category, amount, note, 0);
            }
        }
    }
}