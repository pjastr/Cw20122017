using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Osoba> osoby = new Queue<Osoba>();
            osoby.Enqueue(new Osoba("Jan", Plec.M, new DateTime(2000, 11, 22)));
            osoby.Enqueue(new Osoba("Anna", Plec.K, new DateTime(1980, 4, 30)));
            osoby.Enqueue(new Osoba("Zenon", Plec.M, new DateTime(1990, 7, 4)));
            foreach (var element in osoby)
            {
                Console.WriteLine(element);
            }
        }
    }
}
