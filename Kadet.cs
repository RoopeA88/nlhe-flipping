using System.ComponentModel;

namespace NLHEFLIPPING;

public class Kadet:Program{

    
    public int kortti_luvuksi(string kortti){
        char pilkotaan_kortti = kortti[0];
        int kortti_numerona;
        if (pilkotaan_kortti == 'A'){
            kortti_numerona = 14;
        }
        else if (pilkotaan_kortti == 'K'){
            kortti_numerona = 13;       
        } else if(pilkotaan_kortti == 'Q'){
            kortti_numerona = 12;
        } else if(pilkotaan_kortti == 'J'){
            kortti_numerona = 11;
        } else if(pilkotaan_kortti == 'T'){
            kortti_numerona = 10;
        } else{
            kortti_numerona = (int)char.GetNumericValue(pilkotaan_kortti);
        }
        return kortti_numerona;
    }
    public string luku_kortiksi(int luku){
        if(luku == 14){
            return "A";
        } else if(luku == 13){
            return "K";
        } else if(luku == 12){
            return "Q";
        } else if(luku == 11){
            return "J";
        } else if(luku == 10){
            return "T";
        } else{
            
            return luku.ToString();
        }
    }
    public List<List<int>> onko_vari(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<List<int>> palautettava_lista = new();
        palautettava_lista.Clear();
        List<int> palautettava_numero = new List<int>();
        List<int> kickeri = new List<int>();
        List<List<int>> tyhja = new();
        List<int> tyhja_sisempi = new();
        
        int diamond = 0;
        int club = 0;
        int spade = 0;
        int heart = 0;
        int isoin_d = 2;
        int isoin_c = 2;
        int isoin_s = 2;
        int isoin_h = 2;
        string [] lista = new string[]{pelaajan_kortti1, pelaajan_kortti2, floppi1,floppi2,floppi3,turn,river};
        foreach(string kortti in lista){
            
            if(kortti[1] == 'd'){
                
                diamond++;
                ////("testi");
                if(kortti_luvuksi(kortti) > isoin_d){
                    isoin_d = kortti_luvuksi(kortti);

                }
            }else if(kortti[1] == 'h'){
                heart++;
                if(kortti_luvuksi(kortti) > isoin_h){
                    isoin_h = kortti_luvuksi(kortti);
                }
            } else if(kortti[1] == 's'){
                spade++;
                if(kortti_luvuksi(kortti) > isoin_s){
                    isoin_s = kortti_luvuksi(kortti);
                }
            } else if(kortti[1] == 'c'){
                club++;
                if(kortti_luvuksi(kortti) > isoin_c){
                    isoin_c = kortti_luvuksi(kortti);
                }
            }
        }
        if(diamond > 4){
            ////("testi");
            foreach(string kortti in lista){
                
                if(kortti[1] == 'd'){
                ////($"listaan pistettavat kortit: {kortti} ");
                    kickeri.Add(kortti_luvuksi(kortti));
                    
                } 
            }
            kickeri.Sort();
            //palautettava_lista.Add(kickeri);
            if(isoin_d == 14){
                ////("väri: ässä hai");
            } else if(isoin_d == 13){
                ////("väri: kuningas hai");
            } else if(isoin_d == 12){
                ////("väri: rouva hai");
            } else if(isoin_d == 11){
                ////("väri: jätkä hai");
            } else{
               // //($"väri {isoin_d} hai");
            }
            if(kickeri.Any()){
                ////($"tämä on olevinaan max: {kickeri.Max()}");
                palautettava_numero.Add(kickeri.Max());
                kickeri.Remove(kickeri.Max());
            } 
            palautettava_lista.Add(palautettava_numero);
            palautettava_lista.Add(kickeri);
            
            return palautettava_lista;
        } else if(heart > 4){
            foreach(string kortti in lista){
                if(kortti[1] == 'h'){
                    
                    kickeri.Add(kortti_luvuksi(kortti));
                }
                
            }
            kickeri.Sort();
            //palautettava_lista.Add(kickeri);
            if(isoin_h == 14){
                ////("väri: ässä hai");
            } else if(isoin_h == 13){
                ////("väri: kuningas hai");
            } else if(isoin_h == 12){
                ////("väri: rouva hai");
            } else if(isoin_h == 11){
                ////("väri: jätkä hai");
            } else{
                ////($"väri {isoin_h} hai");
            }
             if(kickeri.Any()){
                palautettava_numero.Add(kickeri.Max());
                 kickeri.Remove(kickeri.Max());
             } 
             palautettava_lista.Add(palautettava_numero);
             palautettava_lista.Add(kickeri);
            return palautettava_lista;
        } else if(spade > 4){
            foreach(string kortti in lista){
                if(kortti[1] == 's'){
                    kickeri.Add(kortti_luvuksi(kortti));
                }
                
            }
            kickeri.Sort();
            //palautettava_lista.Add(kickeri);
            if(isoin_s == 14){
                ////("väri: ässä hai");
            } else if(isoin_s == 13){
                ////("väri: kuningas hai");
            } else if(isoin_s == 12){
                ////("väri: rouva hai");
            } else if(isoin_s == 11){
                ////("väri: jätkä hai");
            } else{
                ////($"väri {isoin_s} hai");
            }
            if(kickeri.Any()){
                palautettava_numero.Add(kickeri.Max());
                kickeri.Remove(kickeri.Max());
            } 
            palautettava_lista.Add(palautettava_numero);
            palautettava_lista.Add(kickeri);
            return palautettava_lista;
        } else if(club > 4){
            foreach(string kortti in lista){
                if(kortti[1] == 'c'){
                    kickeri.Add(kortti_luvuksi(kortti));
                }
                
            }
            kickeri.Sort();
            //palautettava_lista.Add(kickeri);
            if(isoin_c == 14){
                ////("väri: ässä hai");
            } else if(isoin_c == 13){
                ////("väri: kuningas hai");
            } else if(isoin_c == 12){
                ////("väri: rouva hai");
            } else if(isoin_c == 11){
                ////("väri: jätkä hai");
            } else{
                ////($"väri {isoin_c} hai");
            }
             if(kickeri.Any()){
                palautettava_numero.Add(kickeri.Max());
                 kickeri.Remove(kickeri.Max());
             } 
             palautettava_lista.Add(palautettava_numero);
             palautettava_lista.Add(kickeri);
            return palautettava_lista;
        } else{
            tyhja_sisempi.Add(0);
            tyhja.Add(tyhja_sisempi);
            return tyhja;
        }
    }
    public List<int> onko_hai(int kortti1, int kortti2, int floppi1, int floppi2, int floppi3, int turni, int riveri){
        List<int> Lista = new List<int>{kortti1, kortti2, floppi1, floppi2, floppi3, turni, riveri};
        
        Lista.Sort();
        int isoin = Lista.Max();

        if(isoin == 14){
            ////("Pelaajalla on ässä hai.");
            return Lista;
        } else if(isoin == 13){
            ////("Pelaajalla on kuningas hai.");
            return Lista;
        } else if(isoin == 12){
            ////("Pelaajalla on rouva hai.");
            return Lista;
        } else if(isoin == 11){
            ////("Pelaajalla on jätkä hai");
            return Lista;
        } else if(isoin >0 && isoin <15){
            ////($"Pelaajalla on {isoin} hai.");
            return Lista;
        }
        return null;
        

    }
    public int onko_suora(string varisuora_vai_suora,int pelaajan_kortti1, int pelaajan_kortti2, int floppi1, int floppi2, int floppi3, int turn, int river){
        int suoran_laskuri = 0;
        List<int> lista_assan_toimintaa_varten = new List<int>();
        List<int> kuinka_suuri_suora = new List<int>();
        int [] kortit_jarjestyksessa = new int[]{pelaajan_kortti1,pelaajan_kortti2,floppi1,floppi2,floppi3,turn,river};
        kortit_jarjestyksessa = kortit_jarjestyksessa.Distinct().ToArray();
        Array.Sort(kortit_jarjestyksessa);
        for(int i = kortit_jarjestyksessa.Length-1; i > 0; i--){
            
            if(kortit_jarjestyksessa[i-1] == kortit_jarjestyksessa[i]-1){
                suoran_laskuri++;
                kuinka_suuri_suora.Add(kortit_jarjestyksessa[i]);
                ////(suoran_laskuri);
                ////(kuinka_suuri_suora.Max());
            } else{
                suoran_laskuri = 0;
                kuinka_suuri_suora.Clear();
            }
            if(suoran_laskuri == 4 && varisuora_vai_suora == "suora"){
                if(kuinka_suuri_suora.Max() == 14){
                    ////($"Suora: ässä hai");
                } else if(kuinka_suuri_suora.Max() == 13){
                    ////($"Suora: kuningas hai");
                } else if(kuinka_suuri_suora.Max() == 12){
                    ////($"Suora: rouva hai");
                } else if(kuinka_suuri_suora.Max() == 11){
                    ////($"Suora: jätkä hai");
                } else{
                    ////($"Suora: {kuinka_suuri_suora.Max()} hai");
                }
                return kuinka_suuri_suora.Max();
            } else if( varisuora_vai_suora == "suora" && kortit_jarjestyksessa.Contains(14) && kortit_jarjestyksessa.Contains(2) && kortit_jarjestyksessa.Contains(3) && kortit_jarjestyksessa.Contains(4) && kortit_jarjestyksessa.Contains(5) && !kortit_jarjestyksessa.Contains(6) && suoran_laskuri == 0){
                //Console.WriteLine($"Suora: 5 hai");
                return 5;
            } 
                
            if(suoran_laskuri == 4 && varisuora_vai_suora == "värisuora"){
                if(kuinka_suuri_suora.Max() == 14){
                    //($"Värisuora: ässä hai");
                } else if(kuinka_suuri_suora.Max() == 13){
                    //($"Värisuora: kuningas hai");
                } else if(kuinka_suuri_suora.Max() == 12){
                    //($"Värisuora: rouva hai");
                } else if(kuinka_suuri_suora.Max() == 11){
                    //($"Värisuora: jätkä hai");
                } else{
                    //($"Värisuora: {kuinka_suuri_suora.Max()} hai");
                }
                return kuinka_suuri_suora.Max();
            } else if(varisuora_vai_suora == "värisuora" && kortit_jarjestyksessa.Contains(14) && kortit_jarjestyksessa.Contains(2) && kortit_jarjestyksessa.Contains(3) && kortit_jarjestyksessa.Contains(4) && kortit_jarjestyksessa.Contains(5) && !kortit_jarjestyksessa.Contains(6) && suoran_laskuri == 0){
                //($"Värisuora: 5 hai");
                return 5;
            }
                
        }
            return 0;
        }
    public List<int> onko_pari(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
            List<int> kickeri = new List<int>{};
            List<string> korttiArray = new List<string> {pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
            int indeksi = 0;
            int onko_pari = 0;
            int kortin_arvo = 0;
            int kortti_luvuksi_listaan = 0;
            List<string> parit_listassa = new List<string>{};
            string isoin_kortti = "1s";
            
            
            
            while(indeksi <korttiArray.Count){
                foreach(string kortti in korttiArray){
                    if(korttiArray[indeksi][0] == kortti[0] && korttiArray[indeksi] != kortti){
                        onko_pari++;
                        parit_listassa.Add(kortti);
                        kortin_arvo = kortti_luvuksi(kortti);  
                    }
                }
                indeksi++;
            }
            
            foreach(string kortti in korttiArray){
                if(!parit_listassa.Contains(kortti)){
                    kortti_luvuksi_listaan = kortti_luvuksi(kortti);
                    kickeri.Add(kortti_luvuksi_listaan);
                    if(kortti_luvuksi(kortti) > kortti_luvuksi(isoin_kortti)){
                        isoin_kortti = kortti;
                    }
                }
            }
            kickeri.Sort();
            if(onko_pari == 2){
                //kickeri.RemoveAt(0);
                //kickeri.RemoveAt(0);
                int EkaPari = kortti_luvuksi(parit_listassa[1]);
                int TokaPari = kortti_luvuksi(parit_listassa[0]);
                kickeri.Insert(kickeri.Count,EkaPari);
                kickeri.Insert(kickeri.Count-1,TokaPari);
                //($"Pelaajalla on yksi pari {parit_listassa[0]} {parit_listassa[1]}, kickerillä {isoin_kortti}");
                return kickeri;
            } else{
            return null;
            }
            
        }
        
        public List<int> onko_kaksi_paria(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<int> kickeri = new List<int>{};
        List<string> korttiArray = new List<string> {pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
        List<int> parit = new List<int>{};
        List<string> parit_kortteina = new List<string>{};
        List<List<int>> PalautettavaLista = new();
        int indeksi = 0;
        int onko_pari = 0;
        int kortin_arvo = 0;
        
        string isoin_kortti = "1s";
        
        
        while(indeksi <korttiArray.Count){
            foreach(string kortti in korttiArray){
                if(korttiArray[indeksi][0] == kortti[0] && korttiArray[indeksi] != kortti){
                    onko_pari++;
                    parit_kortteina.Add(kortti);
                    kortin_arvo = kortti_luvuksi(kortti);
                    parit.Add(kortin_arvo);  
                } 
            }
            indeksi++;
        }
        foreach(string kortti in korttiArray){
            if(!parit_kortteina.Contains(kortti)){
                int kortti_numerona = kortti_luvuksi(kortti);
                kickeri.Add(kortti_numerona);
                if(kortti_luvuksi(kortti) > kortti_luvuksi(isoin_kortti)){
                    isoin_kortti = kortti;

                }
            }
        }
        int IsoinKickeri = kickeri.Max();
        if(onko_pari == 4){
            
            parit.Sort();
            parit_kortteina.Sort();
            parit.Insert(0,IsoinKickeri);
            //($"Pelaajalla on kaksi paria, {parit_kortteina[0]} {parit_kortteina[1]} ja {parit_kortteina[2]} {parit_kortteina[3]} kickerillä {isoin_kortti}");
            return parit;
        } else{
        return null;
        }
        
    }
    public List<int> onko_kolmoset(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<string> kortit = new List<string>{pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
        List<int> kickeri = new List<int>{};
        List<string> parilliset_kortit = new List<string>();
        List<List<int>> palautettava_lista = new();
        List<int> parilliset_kortit_numerona = new();
        int onko_sama = 0;
        for(int i = 0; i<7;i++){
            foreach(string kortti in kortit){
                if(kortti != kortit[i] && kortti[0] == kortit[i][0]){
                    onko_sama++;
                    parilliset_kortit.Add(kortti);
                    
                }
            }
        }
        foreach(string kortti in kortit){
            if(!parilliset_kortit.Contains(kortti)){
                kickeri.Add(kortti[0]);
            }
        }
        if(onko_sama == 6){
            //($"Pelaajalla on kolmoset: {parilliset_kortit[0]} {parilliset_kortit[1]} {parilliset_kortit[2]} ");
            foreach (var item in parilliset_kortit){
                int item2 = kortti_luvuksi((item));
                parilliset_kortit_numerona.Add(item2);
            }
            parilliset_kortit_numerona.Sort();
            for(int i = 0; i<2; i++){
                int isoin = kickeri.Max();
                parilliset_kortit_numerona.Insert(0,isoin);
                kickeri.Remove(isoin);

            }
            

            {
                
            }
            palautettava_lista.Add(parilliset_kortit_numerona);
            palautettava_lista.Add(kickeri);
            return parilliset_kortit_numerona;
        } else{
            return null;
        }
    }

    public List<int> onko_tayskasi(string kortti1, string kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<List<int>> tayskasi_listaan = new();
        List<string> lista = new List<string>{kortti1, kortti2, floppi1, floppi2, floppi3, turn, river};
        List<string> tayskasi = new List<string>();
        List<string> kolmoset = new List<string>();
        List<string> pari = new List<string>();
        List<int> tyhja = new();
        //List<int> kickeri = new List<int>{};
        List<int> tayskasi_numerona = new();
        tyhja.Append(0);
        int indeksi = 0;
        
        while(indeksi < lista.Count){
            for(int j = 0; j< lista.Count; j++){
                if(lista[indeksi][0] == lista[j][0] && !tayskasi.Contains(lista[indeksi]) && lista[indeksi] != lista[j]){
                    tayskasi.Add(lista[indeksi]);
                    ////(lista[indeksi]);
                    ////("testi");
                    
                }
            }
            indeksi++;
        }
        
        
        
        
        if(tayskasi.Count == 5){
            
            tayskasi.Sort();
            if(kortti_luvuksi(tayskasi[0]) == kortti_luvuksi(tayskasi[1]) && tayskasi[0][0] != tayskasi[2][0]){
                pari.Add(tayskasi[0]);
                kolmoset.Add(tayskasi[2]);
                //($"Pelaajalla täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //kickeri.Add(kortti_luvuksi(pari[0]));
                for(int i = 0; i<kolmoset.Count; i++){ //tämä for-looppi uusin liittyen tuplalistaan. nyt lisätään kolmoiset ekaan listaan, sen jälkeen toisessa for-loopissa pari niin on järjestyksessä ja voidaan käyttää vertaile kickeria metodia myöhemmin
                    tayskasi_numerona.Add(kortti_luvuksi(kolmoset[i]));
                }
                for(int i = 0; i< pari.Count; i++){
                    tayskasi_numerona.Add(kortti_luvuksi(pari[i])); // tämä for-looppi lisää parit kolmosien perään samaan listaan
                }
                tayskasi_listaan.Add(tayskasi_numerona);
                return tayskasi_listaan[0];
            } else if(tayskasi[0][0] == tayskasi[2][0]){
                kolmoset.Add(tayskasi[0]);
                pari.Add(tayskasi[3]);
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //($"Pelaajalla on täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                for(int i = 0; i<kolmoset.Count; i++){ //sama homma kuin ylhäällä, kolmoset ensiksi listaan
                    tayskasi_numerona.Add(kortti_luvuksi(kolmoset[i]));
                }
                for(int i = 0; i<pari.Count; i++){ // oari perään listaan
                    tayskasi_numerona.Add(kortti_luvuksi(pari[i]));
                }
                tayskasi_listaan.Add(tayskasi_numerona);
                return tayskasi_listaan[0];
            }
        } else if(tayskasi.Count == 6 ){
            tayskasi.Sort();
            //kickeri.Clear();
            if(kortti_luvuksi(tayskasi[0]) > kortti_luvuksi(tayskasi[3])){
                kolmoset.Add(tayskasi[0]);
                pari.Add(tayskasi[3]);
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //($"Pelaajalla täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                for(int i = 0; i<kolmoset.Count;i++){
                    tayskasi_numerona.Add(kortti_luvuksi(kolmoset[i]));
                }
                for(int i = 0; i<pari.Count;i++){
                    tayskasi_numerona.Add(kortti_luvuksi(pari[i]));
                }
                tayskasi_listaan.Add(tayskasi_numerona);
                return tayskasi_listaan[0];
            } else{
                kolmoset.Add(tayskasi[3]);
                pari.Add(tayskasi[0]);
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //kickeri.Add(kortti_luvuksi(pari[0]));
                //($"Pelaajalla täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                for(int i = 0; i<kolmoset.Count;i++){
                    tayskasi_numerona.Add(kortti_luvuksi(kolmoset[i]));
                }
                for(int i = 0; i< pari.Count; i++){
                    tayskasi_numerona.Add(kortti_luvuksi(pari[i]));
                }
                tayskasi_listaan.Add(tayskasi_numerona);
                return tayskasi_listaan[0];
            }
        }

        //tietokone
        
         
          
           return null;         
        }
        public int onko_neloset(string kortti1, string kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
            List<string> lista = new List<string>{kortti1, kortti2, floppi1, floppi2, floppi3, turn, river};
            List<string> neloset = new List<string>();
            int indeksi = 0;
            while(indeksi < lista.Count()){
                for(int i = 0; i< lista.Count; i++){
                    if(kortti_luvuksi(lista[indeksi]) == kortti_luvuksi(lista[i]) && lista[indeksi] != lista[i] && !neloset.Contains(lista[indeksi])){
                        ////(lista[indeksi]);
                        neloset.Add(lista[indeksi]);
                    }
                }
                indeksi++;
            }
            if(neloset.Count == 4 && kortti_luvuksi(neloset[0]) == kortti_luvuksi(neloset[1]) && kortti_luvuksi(neloset[0]) == kortti_luvuksi(neloset[2])
            && kortti_luvuksi(neloset[0]) == kortti_luvuksi(neloset[3])){
                return kortti_luvuksi(neloset[0]);
            }
            else if(neloset.Count == 6){
                ////(neloset.Count);
                neloset.Sort();
                if(kortti_luvuksi(neloset[0]) == kortti_luvuksi(neloset[3])){
                    return kortti_luvuksi(neloset[0]);
                } else if(kortti_luvuksi(neloset[2]) == kortti_luvuksi(neloset[5])){
                    return kortti_luvuksi(neloset[2]);
                } else{
                    return 0;
                }
                    
                } else if(neloset.Count == 7){
                    neloset.Sort();
                    if(kortti_luvuksi(neloset[0]) == kortti_luvuksi(neloset[3])){
                        return kortti_luvuksi(neloset[0]);
                    } else{
                        return kortti_luvuksi(neloset[3]);
                    }
                } else{
                    return 0;
                }
                    
        }
        public int onko_varisuora(string kortti1,string kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
            string[] lista = new string[]{kortti1, kortti2, floppi1, floppi2, floppi3, turn, river};
            List<int> hertta = new List<int>();
            List<int> pata = new List<int>();
            List<int> risti = new List<int>();
            List<int> ruutu = new List<int>();
            for(int i = 0; i<lista.Length;i++){
                if(lista[i][1] == 'h'){
                    hertta.Add(kortti_luvuksi(lista[i]));
                } else if(lista[i][1] == 's'){
                    pata.Add(kortti_luvuksi(lista[i]));
                } else if(lista[i][1] == 'c'){
                    risti.Add(kortti_luvuksi(lista[i]));
                } else{
                    ruutu.Add(kortti_luvuksi(lista[i]));
                }
            }
            if(hertta.Count == 5){
                
                return onko_suora("värisuora",hertta[0],hertta[1],hertta[2],hertta[3],hertta[4],-1,-1);
            } else if(pata.Count == 5){
                return onko_suora("värisuora",pata[0],pata[1],pata[2],pata[3],pata[4],-1,-1);
            } else if(risti.Count == 5){
                return onko_suora("värisuora",risti[0],risti[1],risti[2],risti[3],risti[4],-1,-1);
            } else if(ruutu.Count == 5){
                return onko_suora("värisuora",ruutu[0],ruutu[1],ruutu[2],ruutu[3],ruutu[4],-1,-1);
            }
            else if(hertta.Count == 6){
                return onko_suora("värisuora",hertta[0],hertta[1],hertta[2],hertta[3],hertta[4],hertta[5],-1);
            } else if(pata.Count == 6){
                return onko_suora("värisuora",pata[0],pata[1],pata[2],pata[3],pata[4],pata[5],-1);
            } else if(risti.Count == 6){
                return onko_suora("värisuora",risti[0],risti[1],risti[2],risti[3],risti[4],risti[5],-1);
            } else if(ruutu.Count == 6){
                return onko_suora("värisuora",ruutu[0],ruutu[1],ruutu[2],ruutu[3],ruutu[4],ruutu[5],-1);
            } else if(hertta.Count == 7){
                return onko_suora("värisuora",hertta[0],hertta[1],hertta[2],hertta[3],hertta[4],hertta[5],hertta[6]);
            } else if(pata.Count == 7){
                return onko_suora("värisuora",pata[0],pata[1],pata[2],pata[3],pata[4],pata[5],pata[6]);
            } else if(risti.Count == 7){
                return onko_suora("värisuora",risti[0],risti[1],risti[2],risti[3],risti[4],risti[5],risti[6]);
            } else if(ruutu.Count == 7){
                return onko_suora("värisuora",ruutu[0],ruutu[1],ruutu[2],ruutu[3],ruutu[4],ruutu[5],ruutu[6]);
            } else{
                return 0;
            }

        }
}