

namespace Lekcija3_atkartoti
{
    public class Prece_MD
    {
        public string GarumsPrece { get; set; }
        //public int GarumsPrece { get; set; } //ŠIS NESTRĀDĀ
        public string PlatumsPrece { get; set; }
        //public int PlatumsPrece { get; set; }//ŠIS NESTRĀDĀ
        public string AugstumsPrece { get; set; }
        //public int AugstumsPrece { get; set; } //ŠIS NESTRĀDĀ

        public void PrecesIzveidosana()
        { 
        
        }
        public void PrecesDatuAtradisana()
        {
            Console.WriteLine($"Tavas preces izmēri ir Garums {GarumsPrece}, Platums {PlatumsPrece}, Augstums {AugstumsPrece}");
        // JA IZMANTO INT TAD NAV SKAIDRS NO KURIENES PROGRAMMA ŅEM SKAITĻUS
        }
    }
}
