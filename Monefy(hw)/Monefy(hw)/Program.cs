using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoneyOperation obj = new MoneyOperation();
            Console.CursorVisible = false;
            while (true)
            {
                Drawing.GetObj().DrawWindows();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Tab:
                        Drawing.GetObj().selected = (++Drawing.GetObj().selected) % 4;
                        break;
                    case ConsoleKey.Enter:
                        if (Drawing.GetObj().selected == 0)
                        {
                            if (Drawing.GetObj().menu == 0)
                                Drawing.GetObj().menu = 1;
                            else
                                Drawing.GetObj().choose = 0;
                        }
                        else if (Drawing.GetObj().selected == 1)
                        {
                            if (Drawing.GetObj().menu == 0)
                                Drawing.GetObj().menu = 2;
                            else
                                Drawing.GetObj().choose = 1;
                            Drawing.GetObj().selected = 0;
                        }
                        else if (Drawing.GetObj().selected == 2)
                        {
                            if (Drawing.GetObj().menu == 0)
                                Drawing.GetObj().menu = 3;
                            else
                                Drawing.GetObj().choose = 2;
                            Drawing.GetObj().selected = 0;
                        }

                        else if (Drawing.GetObj().selected == 3)
                        {
                            if (Drawing.GetObj().menu == 0)
                                Drawing.GetObj().menu = 4;
                            else
                                Drawing.GetObj().choose = 3;
                            Drawing.GetObj().selected = 0;
                        }
                        break;
                    case ConsoleKey.Escape:
                        if (Drawing.GetObj().menu != 0)
                            Drawing.GetObj().selected = Drawing.GetObj().menu - 1;
                        Drawing.GetObj().menu = 0;
                        Drawing.GetObj().choose = -1;
                        break;
                    case ConsoleKey.C:
                        Drawing.GetObj().menu = 5;
                        break;
                }
            }
        }
    }
}
