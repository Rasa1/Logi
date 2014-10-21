using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Worker
    {
        public Worker()
        {

        }

        public string pesel;
        public string nazwisko;
        public string imie;
        public string stanowisko;
        public int pensja;
        public int etat;




        public Worker(string pesel, string nazwisko, string imie, string stanowisko, int pensja, int etat)
        {
            this.etat = etat;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pensja = pensja;
            this.pesel = pesel;
            this.stanowisko = stanowisko;
        }
    }
}
