using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Entry : IEquatable<Entry>, IComparable<Entry>
    {
        public Entry()
        {

        }

        public string pesel;
        public DateTime enterDate;
        public DateTime exitDate;

        public Entry(string pesel, DateTime entryDate, DateTime exitDate)
        {
            this.pesel = pesel;
            this.enterDate = entryDate;
            this.exitDate = exitDate;
       }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Entry objAsEntry = obj as Entry;
            if (objAsEntry == null) return false;
            else return Equals(objAsEntry);
        }


        public int CompareTo(Entry comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;
            else
                return this.exitDate.CompareTo(comparePart.exitDate);
        }
        
        public override int GetHashCode()
        {
            return exitDate.GetHashCode();
        }

        public bool Equals(Entry other)
        {
            if (other == null) return false;
            return (this.exitDate.Equals(other.exitDate) && this.enterDate.Equals(other.enterDate));
        }

        
    }
}
