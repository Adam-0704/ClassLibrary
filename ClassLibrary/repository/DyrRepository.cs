using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.repository
{
    public class DyrRepository
    {
        private List<Dyr> dyrListe = new List<Dyr>();

        public void TilføjDyr(Dyr dyr)
        {
            dyrListe.Add(dyr);
        }

        public void SletDyr(Dyr dyr)
        {
            dyrListe.Remove(dyr);
        }

        public List<Dyr> HentAlleDyr()
        {
            return dyrListe;
        }

        public bool ErTom()
        {
            return dyrListe.Count == 0;
        }
    }
}

