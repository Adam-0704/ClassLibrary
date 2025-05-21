using System.Security.Cryptography;
using ClassLibrary;
using ClassLibrary.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class PrivacyModel : PageModel
    {
         public List<Bruger> BrugerListe { get; set; } = new();

        public void OnGet()
        {
            BrugerRepository Repo = new BrugerRepository();

            if (Repo.ErTom())
            {
                Repo.TilføjBruger(new Medarbejder("adam", "adam@gmail.com", "12345678"));
                Repo.TilføjBruger(new Kunde("mohib", "mohib@gmail.com", "87654321"));
            }
            BrugerListe = Repo.HentAlleBrugere();
        }
    }

}
