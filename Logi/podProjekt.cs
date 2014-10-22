using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class podProjekt
    {
        public DateTime przydziel;
        public DateTime ukoncz;
        public string pesel;
        public string nazwa;
        public string projekt;
        public string opis;

        public podProjekt(DateTime przydziel, DateTime ukoncz, string pesel, string nazwa,string projekt, string opis)
        {
            this.przydziel = przydziel;
            this.ukoncz = ukoncz;
            this.pesel = pesel;
            this.nazwa = nazwa;
            this.projekt = projekt;
            this.opis = opis;
        }

    }
}
