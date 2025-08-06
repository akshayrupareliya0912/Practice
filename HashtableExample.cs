using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Akshay
{
    internal class HashtableExample
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();

            hs.Add("Name", "Akshay");
            hs.Add("Age", 25);
            hs.Add("Country", "India");
            hs.Add("Occupation", "Software Developer");
            hs.Add("Hobby", "Playing Cricket");
            hs.Add("IsEmployed", false);
            hs.Add("Languages", new List<string> { "C#", "Java", "Flutter", ".Net" });

            foreach (object i in hs.Keys)
            {
                Console.WriteLine(i + " : " + hs[i]);

                if (i.Equals("Languages"))

                {
                    List<string> langs = (List<string>)hs[i];
                    Console.WriteLine("Languages");
                    foreach (string lang in langs)
                    {
                        Console.WriteLine("- " + lang);
                    }
                }
            }
        }
    }
}
