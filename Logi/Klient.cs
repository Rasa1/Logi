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

        Klient(string nazwa,string adres,List <Project> projekty)
        {
            Random rnd = new Random();
            this.adres = adres;
            this.nazwa = nazwa;
            this.nr_telefonu = rnd.Next(100000000,999999999).ToString();
        }

        void genProj(List<Project> projekty,List<Worker> leaders)
        {
            Random rnd = new Random();
            for (int i=0;i<rnd.Next(1,11);i++){
             int wartosc_zamowienia=rnd.Next(100,1000)*100;
             string nazwa="projekt"+this.nazwa+"num"+i.ToString();
             string opis=nazwa.GetHashCode().ToString();
             string pesel=leaders[rnd.Next(leaders.Count)].pesel;
             string klient=this.nazwa;
             List<string>tech=new List<string>();
             
             tech.Add("Java");
             tech.Add(".NET");
             tech.Add("ObjectiveC");
             tech.Add("Ruby");
             tech.Add("C++");
             tech.Add("PHP");
             tech.Add("Bash");
             tech.Add("Html");
            
             string technologia=tech[rnd.Next(tech.Count)];
             DateTime data_zamowienia=new DateTime(2014,rnd.Next(1,13),rnd.Next(1,30));

             DateTime data_min=new DateTime(data_zamowienia.Year,data_zamowienia.Month,data_zamowienia.Day);
             data_min.AddDays(15);
             int range=(new DateTime(2014,12,30)-data_min).Days;
             DateTime data_zakonczenia=new DateTime();
             data_zakonczenia.AddDays(rnd.Next(range));

             projekty.Add(new Project(wartosc_zamowienia, nazwa, opis, pesel, klient, technologia, data_zamowienia, data_zakonczenia));

            }
        }

    }
}
