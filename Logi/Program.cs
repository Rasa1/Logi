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
            List<Entry> logi = new List<Entry>();
            
            int ilosc=Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < ilosc; i++)
                workers.Add(new Worker(workers,wyplaty));
            zespoly(workers, teams);
           

        }

        
        static void zespoly(List<Worker> workers, List<List<Worker>> teams)
        {
            int lzesp=0;
            foreach (Worker worker in workers)
            {
               if (worker.stanowisko == "teamleader")
               {
                    teams.Add(new List<Worker>());
                    teams[teams.Count-1].Add(worker);
                }

            }
            int ktory = 0;
            foreach (Worker worker in workers)
            {
                if (worker.stanowisko != "teamleader")
                {
                    ktory=ktory % teams.Count;
                    teams[ktory].Add(worker);
                    ktory++;
                }
            }
        }
    }
}
