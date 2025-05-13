using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.repository
{
    public class BrugerRepository
    {

        private List<Bruger> brugere = new List<Bruger>();

        public void TilføjBruger(Bruger bruger)
        {
            brugere.Add(bruger);
        }

        
        public List<Bruger> HentAlleBrugere()
        {
            return brugere;
        }

        public bool ErTom()
        {
            return brugere.Count == 0;
        }
        
    }
}
