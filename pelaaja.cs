namespace NLHEFLIPPING;

public class Pelaaja:Kadet{
    
    public void kerro_kortit(){
        Console.WriteLine($"Pelaajalle jaettiin taskukorteiksi {JaetutKortit.pelaajan_kortti1} ja {JaetutKortit.pelaajan_kortti2}");
    }
    //List<List<int>> lista = new(); //tehdään tuplalistalla niin, että ekassa listassa on käden luokitus, esim täyskäsi 7 ja toisessa listassa on se täyskäsi.

    public List<List<int>> mika_kasi(List<List<int>> lista){
        if(onko_varisuora(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_varisuora(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            palautettava_kasikoodi.Add(9);
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_neloset(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_neloset(JaetutKortit.pelaajan_kortti1, JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            palautettava_kasikoodi.Add(8);
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_tayskasi(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)[0] >0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_tayskasi(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri);
            
            palautettava_kasikoodi.Add(7);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_vari(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)[0][0]>0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_vari(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)[1];
            palautettava_kasikoodi.Add(6);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista; 
        } else if(onko_suora("suora",kortti_luvuksi(JaetutKortit.pelaajan_kortti1),kortti_luvuksi(JaetutKortit.pelaajan_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2),kortti_luvuksi(JaetutKortit.floppi3),kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))>0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_suora("suora",kortti_luvuksi(JaetutKortit.pelaajan_kortti1),kortti_luvuksi(JaetutKortit.pelaajan_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2),kortti_luvuksi(JaetutKortit.floppi3),kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri));
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_kolmoset(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)!=null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_kolmoset(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri);
            palautettava_kasikoodi.Add(4);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_kaksi_paria(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) !=null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_kaksi_paria(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            return lista;
        } else if(onko_pari(JaetutKortit.pelaajan_kortti1,JaetutKortit.pelaajan_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) != null){
            List<int> palautettava_kasikoodi = new();
            return 2;
        } else if(onko_hai(kortti_luvuksi(JaetutKortit.pelaajan_kortti1),kortti_luvuksi(JaetutKortit.pelaajan_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2), kortti_luvuksi(JaetutKortit.floppi3), kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))>0){
            return 1;
        } else return 404;
}
}