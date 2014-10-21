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




        public Worker(List<Worker> workers)
        {
            Random rnd = new Random();

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

            this.stanowisko = (rnd.Next(100) > 85) ? "team leader" : ((rnd.Next(100) > 80) ?  "stazysta" :  "teamleader");

            if (this.stanowisko == "team leader")
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
            
            do
            {
                this.pesel = RandomData.randPesel();
            } while (workers.Exists(x => x.pesel == this.pesel));
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
