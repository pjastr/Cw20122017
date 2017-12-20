using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Osoba
    {
        string imie;
        int wiek;
        Plec plec;
        DateTime dataUrodzenia;

        public Osoba(string imie, Plec plec, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.plec = plec;
            this.dataUrodzenia = dataUrodzenia;
            this.wiek = DateTime.Now.Year - dataUrodzenia.Year;
        }

        public override string ToString()
        {
            return String.Format("Imię: {0}, płeć: {1}, wiek: {2}, data urodzenia: {3}",imie,plec,wiek,dataUrodzenia.ToString("dd.MM.yyyy"));
        }

    }
}
