using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.repository
{
    public class ActivityRepository
    {
        private List<Activity> Aktiviteter = new List<Activity>();

        public void TilføjAktivitet(Activity Aktivitet)
        {
            Aktiviteter.Add(Aktivitet);
        }

        public List<Activity> getAll()
        {
            return Aktiviteter;
        }



    }
}
