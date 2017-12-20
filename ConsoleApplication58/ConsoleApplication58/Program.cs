using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList liczby = new ArrayList();
            liczby.Add(1);
            liczby.Add("napis");
            liczby.Add(2);
            liczby.Insert(1, 'k');
            Console.WriteLine(liczby[0]);
            Console.WriteLine(liczby[liczby.Count- 1]);
            liczby.Sort();
             */
            ArrayList nowa = new ArrayList();
            nowa.Add(5d);
            nowa.Add(4d);
            nowa.Add(5.5d);
            nowa.Sort();
            //foreach(var element in nowa)
            //{
             //   Console.WriteLine(element);
            //}
           
            nowa.Contains(5d);
            nowa.Reverse();
            nowa.Remove(5d);
            nowa.RemoveAt(1);
            nowa.Clear();

            List<Osoba> osoby2 = new List<Osoba>();
            osoby2.Add(new Osoba("Jan"));
            osoby2.Add(new Osoba("Anna"));
            osoby2.Add(new Osoba("Zofia"));
            osoby2.Sort();
            osoby2.Clear();
            Console.ReadKey();
        }
    }

    class Osoba:IComparable<Osoba>
    {
        string imie;

        public Osoba(string imie)
        { this.imie = imie; }

        public int CompareTo(Osoba other)
        {
            return other.imie.CompareTo(this.imie);
        }
    }
}
