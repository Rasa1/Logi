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
            List<string> personel = new List<string>();
            for (int i = 0; i < 20; i++)
                personel.Add(RandomData.randPesel());
           
            List<Entry> entrys = new List<Entry>();
            for (int i = 0; i < 20; i++)
                personel.Add(RandomData.randPesel());
        }

        List<Entry> makeEntrys(List<Entry> entrys,List<String>personel)
        {
            
            return entrys;
        }
    }
}
