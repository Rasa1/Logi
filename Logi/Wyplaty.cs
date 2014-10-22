using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    class Wyplaty
    {
        public int godziny;
        public int premia;
        public int miesiac;
        public int rok;
        public int wyplata;
        public int wolne;
        public int urlop;
        public string Pesel;
        public int podatek;

        public Wyplaty(int godziny, int premia, int miesiac,int rok,
                        int wyplata, int wolne, int urlop, string Pesel, int podatek)
        {
            this.godziny = godziny;
             this.premia=premia;
             this.miesiac=miesiac;
             this.rok = rok;
             this.wyplata=wyplata;
             this.wolne=wolne;
             this.urlop=urlop;
             this.Pesel=Pesel;
             this.podatek=podatek;
        }

    }
}
