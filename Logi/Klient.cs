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

        Klient(string nazwa,string nr_telefonu,string adres)
        {
            this.adres = adres;
            this.nazwa = adres;
            this.nr_telefonu = nr_telefonu;
        }
    }
}
