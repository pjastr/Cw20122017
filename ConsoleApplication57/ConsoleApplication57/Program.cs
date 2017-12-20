using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> napisy = new Queue<string>();
            Queue<Osoba> osoby = new Queue<Osoba>();
            napisy.Enqueue("pierwszy napis");
            napisy.Enqueue("drugi napis");
            napisy.Enqueue("trzeci napis");
            foreach(var el in napisy)
            {
                Console.WriteLine(el);
            }
            //napisy.Peek();
            //Console.WriteLine(napisy.Count());
            //Console.ReadKey();
            //napisy.Contains("pooopol");
            //var list = napisy.Reverse().ToList();
            //napisy = new Queue<string>(list);
            //Osoba o1 = new Osoba("Wacław");
            //Osoba o1 = new Osoba("Czesław");
            while (napisy.Count != 0)
            {
                napisy.Dequeue();
            }
            
        }

        class Osoba
        {
            private string imie;
            public Osoba(string imie)
            {
                this.imie = imie;
            }
        }
        
    }
}
