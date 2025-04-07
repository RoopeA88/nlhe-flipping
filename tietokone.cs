namespace NLHEFLIPPING;

public class Tietokone:Kadet{
    
    public void kerro_kortit(){
        Console.WriteLine($"Pelaajalle jaettiin taskukorteiksi {JaetutKortit.tietokoneen_kortti1} ja {JaetutKortit.tietokoneen_kortti2}");
    }
    //List<List<int>> lista = new(); //tehdään tuplalistalla niin, että ekassa listassa on käden luokitus, esim täyskäsi 7 ja toisessa listassa on se täyskäsi.

    public List<List<int>> mika_kasi(List<List<int>> lista){
        if(onko_varisuora(JaetutKortit.tietokoneen_kortti1, JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_varisuora(JaetutKortit.tietokoneen_kortti1, JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            palautettava_kasikoodi.Add(9);
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on värisuora {luku_kortiksi(kickeri_listaan)} hai");
            return lista;
        } else if(onko_neloset(JaetutKortit.tietokoneen_kortti1, JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) >0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_neloset(JaetutKortit.tietokoneen_kortti1, JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            palautettava_kasikoodi.Add(8);
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on {luku_kortiksi(kickeri_listaan)} neloset");
            return lista;
        } else if(onko_tayskasi(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri) != null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_tayskasi(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri);
            
            palautettava_kasikoodi.Add(7);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
             if(verrattava_kickeri[0] == verrattava_kickeri[2]){
                Console.WriteLine($"Tietokoneella on täyskäsi, {luku_kortiksi(verrattava_kickeri[0])} täynnä {luku_kortiksi(verrattava_kickeri[3])}");
            } else if(verrattava_kickeri[4] == verrattava_kickeri[2]){
                Console.WriteLine($"Tietokoneella on täyskäsi, {luku_kortiksi(verrattava_kickeri[4])} täynnä {luku_kortiksi(verrattava_kickeri[0])}");
            }
            return lista;
        } else if(onko_vari(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)[0][0]>0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_vari(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)[1];
            palautettava_kasikoodi.Add(6);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on väri, {luku_kortiksi(verrattava_kickeri.Max())} hai");
            return lista; 
        } else if(onko_suora("suora",kortti_luvuksi(JaetutKortit.tietokoneen_kortti1),kortti_luvuksi(JaetutKortit.tietokoneen_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2),kortti_luvuksi(JaetutKortit.floppi3),kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))>0){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = new();
            int kickeri_listaan = onko_suora("suora",kortti_luvuksi(JaetutKortit.tietokoneen_kortti1),kortti_luvuksi(JaetutKortit.tietokoneen_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2),kortti_luvuksi(JaetutKortit.floppi3),kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri));
            verrattava_kickeri.Add(kickeri_listaan);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on suora, {luku_kortiksi(kickeri_listaan)} hai");
            return lista;
        } else if(onko_kolmoset(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri)!=null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_kolmoset(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1,JaetutKortit.floppi2,JaetutKortit.floppi3,JaetutKortit.turni,JaetutKortit.riveri);
            palautettava_kasikoodi.Add(4);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on {luku_kortiksi(verrattava_kickeri[verrattava_kickeri.Count-1])} kolmoset");
            return lista;
        } else if(onko_kaksi_paria(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) !=null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_kaksi_paria(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on kaksia paria, {luku_kortiksi(verrattava_kickeri[verrattava_kickeri.Count-3])} ja {luku_kortiksi(verrattava_kickeri[verrattava_kickeri.Count-1])}");
            return lista;
        } else if(onko_pari(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri) != null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_pari(JaetutKortit.tietokoneen_kortti1,JaetutKortit.tietokoneen_kortti2,JaetutKortit.floppi1, JaetutKortit.floppi2, JaetutKortit.floppi3, JaetutKortit.turni, JaetutKortit.riveri);
            palautettava_kasikoodi.Add(2);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on {luku_kortiksi(verrattava_kickeri[verrattava_kickeri.Count-1])} pari");
            return lista;
        } else if(onko_hai(kortti_luvuksi(JaetutKortit.tietokoneen_kortti1),kortti_luvuksi(JaetutKortit.tietokoneen_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2), kortti_luvuksi(JaetutKortit.floppi3), kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri))!=null){
            List<int> palautettava_kasikoodi = new();
            List<int> verrattava_kickeri = onko_hai(kortti_luvuksi(JaetutKortit.tietokoneen_kortti1),kortti_luvuksi(JaetutKortit.tietokoneen_kortti2),kortti_luvuksi(JaetutKortit.floppi1), kortti_luvuksi(JaetutKortit.floppi2), kortti_luvuksi(JaetutKortit.floppi3), kortti_luvuksi(JaetutKortit.turni), kortti_luvuksi(JaetutKortit.riveri));
            palautettava_kasikoodi.Add(1);
            lista.Add(palautettava_kasikoodi);
            lista.Add(verrattava_kickeri);
            Console.WriteLine($"Tietokoneella on {luku_kortiksi(verrattava_kickeri.Max())} hai");
            return lista;
        } else return null;
}
}