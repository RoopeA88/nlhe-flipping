// See https://aka.ms/new-console-template for more information




    


using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Security;
using NLHEFLIPPING;



public class Program{
    
    List<List<int>> lista = new();
    List<List<int>> lista2 = new();
    static void Main(){
    Program ohjelma = new();
    Pelaaja pelaaja = new Pelaaja();
    Pelaaja pelaaja2 = new Pelaaja();
    Kortit cards = new Kortit();
    Pakka pakka = new Pakka(cards);
    JaetutKortit jaetut_kortit = new JaetutKortit(pakka);
    //jaetut_kortit.kasitesti();
    jaetut_kortit.jaa_kortit();
    Kicker vertaile = new();
    
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.pelaajan_kortti1));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.pelaajan_kortti2));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi1));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi2));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.floppi3));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.turni));
    // ohjelma.pelaajan_kickeri.Add(pelaaja.kortti_luvuksi(JaetutKortit.riveri));
    // ohjelma.lista.Add(ohjelma.pelaajan_kickeri);
    pelaaja.kerro_kortit();
    pelaaja2.kerro_kortit();
    jaetut_kortit.kerro_poyta();
    // Console.WriteLine(pelaaja.mika_kasi(ohjelma.lista));
    // for(int i = 0; i<ohjelma.lista[0].Count; i++){
    //     Console.WriteLine(ohjelma.lista[0][i]);
    // }
    if(pelaaja.mika_kasi(ohjelma.lista)[0][0] > pelaaja2.mika_kasi(ohjelma.lista2)[0][0]){
        Console.WriteLine("Pelaaja voittaa!");
    } else if (pelaaja2.mika_kasi(ohjelma.lista2)[0][0] > pelaaja.mika_kasi(ohjelma.lista)[0][0]){
        Console.WriteLine("Tietokone voittaa!");
    } else{
        vertaile.vertaile_kickereita(ohjelma.lista[1], ohjelma.lista2[1]);

        }
    }
 }



