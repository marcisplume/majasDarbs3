

namespace Lekcija3_atkartoti
{
    public class Cilveks
    {

        public Cilveks(string vards)
        {

            Vards = vards;
        
        }

        public Cilveks()

        { 
        
        
        }


        public string Vards { get; set; }
        
        public int Vecums { get; set; }

        public bool VaiVecis { get; set; }

        public bool IrPieaudzis 
        
        
        {
            get
            {
                return Vecums >= 18;
            }
                
                }


        //public Masina Masina { get; set; }




        public void Sveiciens()
            {

            Console.WriteLine($"Sveiks! mans vārds ir: {Vards} un man ir {Vecums} gadi!");

            }
        public bool GetIrPieaudzis()
        { 
            return Vecums >= 18; 
        
        }
    }
}
