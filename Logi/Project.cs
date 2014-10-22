using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Project : IEquatable<Project>
    {
        Project()
        {

        }

        public int wartosc_zamowienia;
        public string nazwa;
        public string opis;
        public string pesel;
        public string klient;
        public string technologia;
        public DateTime data_zakonczenia;
        public DateTime data_zamowienia;

        public Project(int wartosc_zamowienia,string nazwa,string opis,string pesel,string klient,string technologia,DateTime data_zakonczenia,DateTime data_zamowienia)
        {
            this.data_zakonczenia = data_zakonczenia;
            this.pesel = pesel;
            this.data_zamowienia = data_zamowienia;
            this.klient = klient;
            this.nazwa = nazwa;
            this.opis = opis;
            this.technologia = technologia;
            this.wartosc_zamowienia = wartosc_zamowienia;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Project objAsProject = obj as Project;
            if (objAsProject == null) return false;
            else return Equals(objAsProject);
        }
        public override int GetHashCode()
        {
            return this.nazwa.GetHashCode();
        }
        public bool Equals(Project other)
        {
            if (other == null) return false;
            return (this.nazwa.Equals(other.nazwa));
        }
    }

    


}
