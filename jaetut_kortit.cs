namespace NLHEFLIPPING;

public class JaetutKortit{
    Pakka pakka;
    public static string pelaajan_kortit;
    public static string pelaajan_kortti1;
    public static string pelaajan_kortti2;
    public static string tietokoneen_korttit;
    public static string tietokoneen_kortti1;
    public static string tietokoneen_kortti2;
    public static string floppi;
    public static string floppi1;
    public static string floppi2;
    public static string floppi3;
    public static string turni;
    public static string riveri;

    public  void jaa_kortit(){
        pelaajan_kortit = pakka.jaa_pelaajan_kortit();
        pelaajan_kortti1 = pelaajan_kortit.Substring(0,2);
        pelaajan_kortti2 = pelaajan_kortit.Substring(2,2);
        tietokoneen_korttit = pakka.jaa_vastustajan_kortit();
        tietokoneen_kortti1 = tietokoneen_korttit.Substring(0,2);
        tietokoneen_kortti2 = tietokoneen_korttit.Substring(2,2);
        floppi = pakka.jaa_floppi();
        floppi1 = floppi.Substring(0,2);
        floppi2 = floppi.Substring(2,2);
        floppi3 = floppi.Substring(4,2);
        turni = pakka.jaa_turni();
        riveri = pakka.jaa_riveri();

    }
    public void kerro_poyta(){
        Console.WriteLine($"Pöytä on {floppi1} {floppi2} {floppi3} {turni} {riveri}");
    }
    public JaetutKortit(Pakka _pakka){
        pakka = _pakka;
    }
}