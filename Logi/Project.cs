using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Project
    {
        Project()
        {

        }

        public int wartosc_zamowienia;
        public string nazwa;
        public string opis;
        public string klient;
        public string technologia;
        public DateTime data_zakonczenia;
        public DateTime data_zamowienia;

        Project(int wartosc_zamowienia,string nazwa,string opis,string klient,string technologia,DateTime data_zakonczenia,DateTime data_zamowienia)
        {
            this.data_zakonczenia = data_zakonczenia;
            this.data_zamowienia = data_zamowienia;
            this.klient = klient;
            this.nazwa = nazwa;
            this.opis = opis;
            this.technologia = technologia;
            this.wartosc_zamowienia = wartosc_zamowienia;
        }
    }

    


}
