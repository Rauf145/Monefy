using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    sealed class Text
    {
        private static Text obj;
        public int selectedLanguage { get; set; }
        List<string> English = new List<string>();
        List<string> Russian = new List<string>();

        private Text()
        {
            selectedLanguage = 0;
            //char[] tmp = new char[20];
           // string test = "привет";
           // Console.WriteLine(test);
            string word = "";
            using (StreamReader sr = File.OpenText("English.txt"))
            {
                while ((word = sr.ReadLine()) != null)
                {
                    English.Add(word);
                }
            }
            using (StreamReader sr = File.OpenText("Russian.txt"))
            {
                while ((word = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(word);
                    Russian.Add(word);
                }
                //Console.ReadKey();
            }
        }

        public static Text getObj()
        {
            if (obj == null)
                obj = new Text();
            return obj;
        }

        //public void showText()  //testing//
        //{
        //    foreach (var item in English)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    foreach (var item in Russian)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public string this[int index]
        {
            get
            {
                if (selectedLanguage == 0)
                    return English[index];
                else 
                    return Russian[index];
            }
        }
    }
}
