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
            int ilosc=Convert.ToInt32(Console.ReadLine());
            List<Worker> workers = new List<Worker>();
            List<Wyplaty> wyplaty=new List<Wyplaty>();
            for (int i = 0; i < ilosc; i++)
                workers.Add(new Worker(workers,wyplaty));
           

        }
           /*
        List<Entry> makeEntrys(List<Entry> entrys,List<String>personel)
        {

            return entrys;
        }*/
    }
}
