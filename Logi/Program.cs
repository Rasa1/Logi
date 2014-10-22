using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<Worker>> teams = new List<List<Worker>>();
            List<Worker> workers = new List<Worker>();
            List<Wyplaty> wyplaty = new List<Wyplaty>();
            List<Project> projekty = new List<Project>();
            List<Entry> entrys = new List<Entry>();
            List<Klient> klienci = new List<Klient>();

            List<podProjekt> podprojekty = new List<podProjekt>();

            int ilosc = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ilosc; i++)
                workers.Add(new Worker(workers, wyplaty,entrys));
            zespoly(workers, teams);

            createProjekty(projekty, teams, podprojekty);

            createKlienci(klienci,projekty);

        }

        static void zespoly(List<Worker> workers, List<List<Worker>> teams)
        {
            foreach (Worker worker in workers)
            {
                if (worker.stanowisko == "teamleader")
                {
                    teams.Add(new List<Worker>());
                    teams[teams.Count - 1].Add(worker);
                }

            }
            int ktory = 0;
            foreach (Worker worker in workers)
            {
                if (worker.stanowisko != "teamleader")
                {
                    ktory = ktory % teams.Count;
                    teams[ktory].Add(worker);
                    ktory++;
                }
            }
        }
        static void createProjekty(List<Project> projekty, List<List<Worker>> teams, List<podProjekt> podprojekty)
        {
            Random rnd = new Random();
            foreach (List<Worker> zespol in teams)
            {
                DateTime start = new DateTime(2014, 1, 1);

                TimeSpan span = new DateTime(2014, 12, 30) - start;

                do
                {

                    int dni = rnd.Next(1, 7) * 7;
                    DateTime end = new DateTime(start.Year, start.Month, start.Day);
                    if (span.Days > 49) end=end.AddDays(dni);
                    else end = new DateTime(2014, 12, 30);

                    int wartosc_zamowienia = rnd.Next(100, 1000) * 100;
                    string nazwa = "projekt" + zespol[0].pesel + "num" + start.Year.ToString()+start.Month.ToString()+start.Day.ToString();
                    string opis = nazwa.GetHashCode().ToString();
                    string pesel = zespol[0].pesel;
                    string klient = "";

                    List<string> tech = new List<string>();

                    tech.Add("Java");
                    tech.Add(".NET");
                    tech.Add("ObjectiveC");
                    tech.Add("Ruby");
                    tech.Add("C++");
                    tech.Add("PHP");
                    tech.Add("Bash");
                    tech.Add("Html");

                    string technologia = tech[rnd.Next(tech.Count)];

                    projekty.Add(new Project(wartosc_zamowienia, nazwa, opis, pesel, klient, technologia, start, end));
                    podprojekt(podprojekty, zespol, start, end, nazwa);

                    start = end;
                    span = new DateTime(2014, 12, 30) - start;

                } while (span.Days > 49);
            }

        }

        static void podprojekt(List<podProjekt> podprojekty, List<Worker> team, DateTime start, DateTime end, string projekt)
        {
            Random rnd = new Random();
            foreach (Worker pracownik in team)
            {
                
                DateTime startpod = new DateTime(start.Year, start.Month, start.Day);
                TimeSpan span = end - start;
                do
                {
                    DateTime endpod = new DateTime(startpod.Year, startpod.Month, startpod.Day);
                    if (span.Days > 4)
                    {
                        int dni = rnd.Next(1, 4);
                        endpod=endpod.AddDays(dni);
                    }
                    else { endpod = end; }
                    string pesel = pracownik.pesel;
                    string nazwa = pesel+"num" + startpod.Year.ToString() + startpod.Month.ToString() + startpod.Day.ToString();
                    //string projekt;
                    string opis = nazwa.GetHashCode().ToString();
                    podprojekty.Add(new podProjekt(startpod, endpod, pesel, nazwa, projekt, opis));

                    startpod = endpod;
                    span = end - startpod;
                } while (span.Days > 4);

            }
        }
        
        static void createKlienci(List<Klient> klienci, List<Project> projekty)
        {
            Random rnd = new Random();
            int ilosc=rnd.Next(1,projekty.Count);

            for (int i = 0; i < ilosc; i++)
            {
                string nazwa = "klient" + i.ToString();
                string adres = "adres" + i.ToString();
                klienci.Add(new Klient(nazwa, adres));
            }

            for (int i = 0; i < projekty.Count; i++)
            {
                if (i < ilosc) projekty[i].klient = klienci[i].nazwa;
                else projekty[i].klient = klienci[rnd.Next(klienci.Count)].nazwa;
            }
        }
        
    }
}
