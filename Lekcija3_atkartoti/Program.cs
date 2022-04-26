

using Lekcija3_atkartoti;



Console.WriteLine("___________________________I dala - Telefons___________________________________");

Prece talrunis1 = new Prece();

Console.WriteLine("Ieraksti tālruņa marku!");
talrunis1.Marka = Console.ReadLine();

Console.WriteLine("Ieraksti tālruņa Modeli!");
talrunis1.Modelis = Console.ReadLine();

Console.WriteLine("Ieraksti tālruņa garumu");
string GarumsVardiem = Console.ReadLine();
int GarumsSkaitlis = int.Parse(GarumsVardiem);
talrunis1.Garums = GarumsSkaitlis;


Console.WriteLine("Ieraksti tālruņa platumu");
string PlatumsVardiem = Console.ReadLine();
int PlatumsSkaitlis = int.Parse(PlatumsVardiem);
talrunis1.Platums = PlatumsSkaitlis;

Console.WriteLine("Ieraksti tālruņa augstumu");
string AugstumsVardiem = Console.ReadLine();
int AugstumsSkaitlis = int.Parse(AugstumsVardiem);
talrunis1.Augstums = AugstumsSkaitlis;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("___________________________II dala - Mašīna___________________________________");
Console.WriteLine();
Console.WriteLine();

Masina Masina1 = new Masina();
Console.WriteLine("Ieraksti mašīnas marku!");
Masina1.Brand = Console.ReadLine();

Console.WriteLine("Ieraksti mašīnas nummurzīmi!");
Masina1.Nummurzime = Console.ReadLine();

Console.WriteLine("Ieraksti mašīnas ātrumu!");
string AtrumsVardiem = Console.ReadLine();
int AtrumsCipariem = int.Parse(AtrumsVardiem);
Masina1.Atrums = AtrumsCipariem;
Masina1.Uztauret();



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("___________________________III dala - Prece___________________________________");
Console.WriteLine();
Console.WriteLine();

Prece_MD prece1 = new Prece_MD();
Console.WriteLine("Ieraksti preces garumu");
prece1.GarumsPrece = Console.ReadLine();

//string PrecesGarumsVardiem = Console.ReadLine();
//int PrecesGarumsSkaitlis = int.Parse(PrecesGarumsVardiem);
//prece1.GarumsPrece = PrecesGarumsSkaitlis;


Console.WriteLine("Ieraksti preces platumu");
prece1.PlatumsPrece = Console.ReadLine();

//string PrecesPlatumsVardiem = Console.ReadLine();
//int PrecesPlatumsSkaitlis = int.Parse(PrecesPlatumsVardiem);
//prece1.GarumsPrece = PrecesPlatumsSkaitlis;


Console.WriteLine("Ieraksti preces augstumu");
prece1.AugstumsPrece = Console.ReadLine();

//string PrecesAugstumsVardiem = Console.ReadLine();
//int PrecesAugstumsSkaitlis = int.Parse(PrecesAugstumsVardiem);
//prece1.AugstumsPrece = PrecesAugstumsSkaitlis;

prece1.PrecesDatuAtradisana();



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("___________________________IV dala - Persona___________________________________");
Console.WriteLine();
Console.WriteLine();


Persona_MD persona2 = new Persona_MD();

Console.WriteLine("Kāds ir tavs vārds?");
persona2.VardsMD = Console.ReadLine();

Console.WriteLine("Kāds ir tavs uzvārds?");
persona2.UzvardsMD = Console.ReadLine();


Console.WriteLine("Kāds ir tavs dzimšanas gads?");
string DzimsasnasGadsvardiem = Console.ReadLine();
int DzimsanasGadsCipars = int.Parse(DzimsasnasGadsvardiem);
persona2.DzimsanasGads = DzimsanasGadsCipars;

Console.WriteLine("Kāds ir tavs hobijs?");
persona2.Hobijs = Console.ReadLine();

persona2.SveiciensMD();

// jābut vecuma aprekinam


