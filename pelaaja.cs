namespace NLHEFLIPPING;

public class Pelaaja:Kadet{
    
    public void kerro_kortit(){
        Console.WriteLine($"Pelaajalle jaettiin taskukorteiksi {JaetutKortit.pelaajan_kortti1} ja {JaetutKortit.pelaajan_kortti2}");
    }
    

    public int mika_kasi(){
        if(onko_varisuora(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            return 9;
        } else if(onko_neloset(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            return 8;
        } else if(onko_tayskasi(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri) >0){
            return 7;
        } else if(onko_vari(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)>0){
            return 6;
        } else if(onko_suora("suora",kortti_luvuksi(JaetutKortit.pelaajan_kortti1),kortti_luvuksi(JaetutKortit.pelaajan_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2),kortti_luvuksi(JaetutKortit.floppi3),kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))>0){
            return 5;
        } else if(onko_kolmoset(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)>0){
            return 4;
        } else if(onko_kaksi_paria(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) !=null){
            return 3;
        } else if(onko_pari(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            return 2;
        } else if(onko_hai(kortti_luvuksi(JaetutKortit.pelaajan_kortti1),kortti_luvuksi(JaetutKortit.pelaajan_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2), kortti_luvuksi(JaetutKortit.floppi3), kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))>0){
            return 1;
        } else return 404;
}
}