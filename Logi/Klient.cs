using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Klient
    {
        Klient()
        {

        }

        public string nazwa;
        public string nr_telefonu;
        public string adres;

        public Klient(string nazwa, string adres)
        {
            Random rnd = new Random();
            this.adres = adres;
            this.nazwa = nazwa;
            this.nr_telefonu = rnd.Next(100000000,999999999).ToString();
        }

        
        public string ToString(List<Klient> klienci)
        {
            string s = "";
            foreach (Klient klient in klienci)
            {
                s += klient.nazwa + ",";
                s += klient.adres + ",";
                s += klient.nr_telefonu + Environment.NewLine;
            }
            return s;
        }

    }
}
