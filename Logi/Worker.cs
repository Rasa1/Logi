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

        public String pesel;
        public String nazwisko;
        public String imie;
        public String stanowisko;
        public int pensja;
        public int etat;

        public Worker(String pesel, String nazwisko, String imie, String stanowisko, int pensja, int etat)
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
