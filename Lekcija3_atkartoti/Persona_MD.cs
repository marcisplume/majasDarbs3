

namespace Lekcija3_atkartoti
{
    public class Persona_MD
    {public string VardsMD { get; set; }
        public string UzvardsMD { get; set; }
        public int DzimsanasGads { get; set; }
        public string Hobijs { get; set; }
        public string Dzimums { get; set; }

        public void SveiciensMD()
        {

            Console.WriteLine($"Sveiks! Mani sauc {VardsMD} { UzvardsMD}!");

        }
        public void AprekinatsVecums()
        {

            Console.WriteLine($"Esmu gadus vecs"); // KAUT KAS NESTRĀDĀ

        }

    }
}
