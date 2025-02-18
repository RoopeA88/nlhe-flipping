// See https://aka.ms/new-console-template for more information




    


using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Security;
using NLHEFLIPPING;



public class Program{
    public List<int> pelaajan_kickeri = new List<int>();
    public List<int> tietokoneen_kickeri = new List<int>();
    List<List<int>> lista = new();
    static void Main(){
    Program ohjelma = new();
    Pelaaja pelaaja = new Pelaaja();
    Kortit cards = new Kortit();
    Pakka pakka = new Pakka(cards);
    JaetutKortit jaetut_kortit = new JaetutKortit(pakka);
    jaetut_kortit.varitesti();
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.pelaajan_kortti1));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.pelaajan_kortti2));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi1));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi2));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi3));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.turni));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.riveri));
    // ohjelma.lista.Add(ohjelma.pelaajan_kickeri);
    pelaaja.kerro_kortit();
    jaetut_kortit.kerro_poyta();
    Console.WriteLine(pelaaja.mika_kasi(ohjelma.lista));
    for(int i = 0; i<ohjelma.lista[0].Count; i++){
        Console.WriteLine(ohjelma.lista[0][i]);
    }
 }

}

