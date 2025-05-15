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
        private List<Activity> aktiviteter = new List<Activity>();

        public void TilføjAktivitet(Activity aktivitet)
        {
            aktiviteter.Add(aktivitet);
        }

        public List<Activity> getAll()
        {
            return aktiviteter;
        }

        public bool ErTom()
        {
            return aktiviteter.Count == 0;
        }
    }
}
