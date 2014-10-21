using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Entry
    {
        public Entry()
        {

        }

        public String pesel;
        public DateTime entryDate;
        public DateTime exitDate;

        public Entry(String pesel, DateTime entryDate, DateTime exitDate)
        {
            this.pesel = pesel;
            this.entryDate = entryDate;
            this.exitDate = exitDate;
       }

        
    }
}
