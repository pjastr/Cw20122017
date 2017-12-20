using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> slownik = new Dictionary<string, int>();
            slownik.Add("pierwsza", 1);
            slownik["druga"] = 2;
            slownik["druga"] = 2;
            foreach(KeyValuePair<string, int> kvp in slownik)
            {
                Console.WriteLine("{"+kvp.Key+";"+kvp.Value+"}");
            }
            Console.WriteLine(slownik.First());
            Console.WriteLine(slownik.Count());
            slownik.ContainsKey("pierwsza");
            slownik.Clear();
        }
    }
}
