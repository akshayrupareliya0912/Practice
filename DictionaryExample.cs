/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class DictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<object, string> person = new Dictionary<object, string>();
            person.Add("Name", "Akshay");
            person.Add("Age", "25");
            person.Add("Country", "India");

            foreach (KeyValuePair<object, string> data in person) {
                Console.WriteLine($"{data.Key},{data.Value}");
            }
            
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //Adding Elements to the Dictionary using Add Method of Dictionary class
           
             dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");
            dictionaryCountries.Add("INDIA", "Mumbai");

            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            //check availability of a key/value pair 
            Console.WriteLine();
            Console.WriteLine("The UK country name is available " + dictionaryCountries.ContainsKey("UK"));
            Console.WriteLine("The japan country name is available " + dictionaryCountries.ContainsKey("Japan"));

            Console.WriteLine("The Mumbai is available " + dictionaryCountries.ContainsValue("Mumbai"));
            
            dictionaryCountries["IND"] = "India";
            dictionaryCountries["PAK"] = "Pakistan";
            dictionaryCountries["SL"] = "Srilanka";

            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");
        }
    }
}*/