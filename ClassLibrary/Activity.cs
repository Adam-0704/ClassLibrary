using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Activity
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse{ get; set; }
        public DateOnly Dato { get; set; }

        public Activity(int id, DateOnly dato, string navn, string beskrivelse) 
        {
            Id = id;
            Dato = dato;
            Navn = navn;
            Beskrivelse = beskrivelse;
        }

        // For backward compatibility, you can keep the old constructor if needed
        public Activity(DateOnly dato, string navn, string beskrivelse)
            : this(0, dato, navn, beskrivelse) // Default Id to 0
        {
        }

        public void VisInfo()
        {
            Console.WriteLine($"\n[{Id}] [{Navn}]: {Beskrivelse} - {Dato}  ");
        }
    }
}
