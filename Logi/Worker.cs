using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Worker : IEquatable<Worker>
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




        public Worker(List<Worker> workers, List<Wyplaty> wyplaty, List<Entry> logi)
        {
            Random rnd = new Random();

            do
            {
                this.pesel = RandomData.randPesel();
            } while (workers.Exists(x => x.pesel == this.pesel));

            List<string> imiona = new List<string>();
            imiona.Add("Adam");
            imiona.Add("Marcin");
            imiona.Add("Krzysztof");
            imiona.Add("Tomasz");
            imiona.Add("Rafał");
            imiona.Add("Wojciech");
            imiona.Add("Kamil");
            imiona.Add("Agnieszka");
            imiona.Add("Katarzyna");
            imiona.Add("Anna");
            imiona.Add("Monika");
            imiona.Add("Patryk");
            imiona.Add("Mateusz");
            imiona.Add("Jacek");
            imiona.Add("Adrian");
            imie = imiona[rnd.Next(imiona.Count)];

            List<string> nazwiska = new List<string>();
            nazwiska.Add("Wolno");
            nazwiska.Add("Konrad");
            nazwiska.Add("Rozwadowski");
            nazwiska.Add("Suryn");
            nazwiska.Add("Kuta");
            nazwiska.Add("Szwermer");
            nazwiska.Add("Mordehaj");
            nazwiska.Add("Nowak");
            nazwiska.Add("Salnik");
            nazwiska.Add("Mohamed");
            nazwiska.Add("Gołota");
            nazwiska.Add("Bednarek");
            nazwiska.Add("Smith");
            nazwiska.Add("Szmidka");
            nazwiska.Add("Jelonek");
            nazwiska.Add("Zabawa");
            nazwisko = nazwiska[rnd.Next(nazwiska.Count)];

            this.stanowisko = (rnd.Next(100) > 85) ? "teamleader" : ((rnd.Next(100) > 80) ?  "stazysta" :  "programista");

            if (this.stanowisko == "teamleader")
            {
                etat = 40;
                pensja = rnd.Next(50, 80)*100;
            }
            else if (this.stanowisko == "programista")
            {
                etat = rnd.Next(24, 40);
                this.pensja = rnd.Next(30,80)*100;
            }
            else if (this.stanowisko == "stazysta")
            {
                this.etat = 24;
                this.pensja = 2700;
            }
            
            
            this.setWyplaty(wyplaty,logi);
        }

        public void setWyplaty(List<Wyplaty> wyplaty, List<Entry> logi)
        {
            Random rnd = new Random();
            int[] dni_wolne = new int[] { 2, 1, 1, 2, 0, 1, 0, 0, 2, 1, 1, 3 };
            int[] dni_w_miesiacu = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
            for (int miesiac = 1; miesiac <= 12; miesiac++)
            {
                int ile_godzin_w_miesiacu=0;
                for(int dzien=1;dzien<=dni_w_miesiacu[miesiac-1];dzien++)
                {
                    if (rnd.Next(0,1000)>=714)
                        continue;
                    int ile_godzin=rnd.Next(this.etat/5-2,this.etat/5+2);
                    ile_godzin_w_miesiacu+=ile_godzin;
                    int o_ktorej_przyszedl = rnd.Next(6,22-ile_godzin);
                    int o_ktorej_wyszedl = o_ktorej_przyszedl+ile_godzin;
                    logi.Add(new Entry(this.pesel,new DateTime(2014,miesiac,dzien,o_ktorej_przyszedl,0,0),new DateTime(2014,miesiac,dzien,o_ktorej_wyszedl,0,0)));
                }
                int godziny = ile_godzin_w_miesiacu;
                int premia = rnd.Next(0, 500);
                int wyplata = this.pensja + premia;
                int wolne = dni_wolne[miesiac-1];
                int urlop = rnd.Next(0, 4);
                string pesel = this.pesel;
                int podatek = wyplata / 3;

                wyplaty.Add(new Wyplaty(godziny,premia,miesiac,2014,wyplata,wolne,urlop,pesel,podatek));
            }
        }

        public string ToString(List<Worker> workers)
        {
            string s="";
            foreach (Worker worker in workers)
            {
                s += worker.pesel + ",";
                s += worker.nazwisko + ",";
                s += worker.imie + ",";
                s += worker.stanowisko + ",";
                s += worker.etat.ToString() + ",";
                s += worker.pensja.ToString();
                s += Environment.NewLine;
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Worker objAsWorker = obj as Worker;
            if (objAsWorker == null) return false;
            else return Equals(objAsWorker);
        }
        public override int GetHashCode()
        {
            return this.pesel.GetHashCode();
        }
        public bool Equals(Worker other)
        {
            if (other == null) return false;
            return (this.pesel.Equals(other.pesel));
        }
    }
}
