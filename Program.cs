// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Security;
Random random = new Random();

string [] kortit = new string[]{"Ah","2h","3h","4h","5h","6h","7h","8h","9h","Th","Jh","Qh","Kh",
                                "Ad","2d","3d","4d","5d","6d","7d","8d","9d","Td","Jd","Qd","Kd",
                                "As","2s","3s","4s","5s","6s","7s","8s","9s","Ts","Js","Qs","Ks",
                                "Ac","2c","3c","4c","5c","6c","7c","8c","9c","Tc","Jc","Qc","Kc"};

List<string> kortit_listana = new List<string>(kortit);


string pelaajan_kortti1;
string pelaajan_kortti2;
List<int> kickeri = new List<int>{};
List<int> tasapeli = new List<int>{0};
List<int> tietokoneen_kickeri = new List<int>{};

string jaa_floppi(){
    int random_luku1 = random.Next(0,48);
    string flopin_eka_kortti = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    int random_luku2 = random.Next(0,47);
    string flopin_toinen_kortti = kortit_listana[random_luku2];
    kortit_listana.RemoveAt(random_luku2);
    int random_luku3 = random.Next(0,46);
    string flopin_kolmas_kortti = kortit_listana[random_luku3];
    string palautettava = flopin_eka_kortti + flopin_toinen_kortti + flopin_kolmas_kortti;
    return palautettava;
}

string jaa_turni(){
    int random_luku1 = random.Next(0,45);
    string turni = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    return turni;
}

string jaa_riveri(){
    int random_luku1 = random.Next(0,44);
    string riveri = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    return riveri;
}




string jaa_pelaajan_kortit(){
    int random_luku1 = random.Next(0,52);
    pelaajan_kortti1 = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    int random_luku2 = random.Next(0,51);
    pelaajan_kortti2 = kortit_listana[random_luku2];
    kortit_listana.RemoveAt(random_luku2);
    string palautettava = pelaajan_kortti1 + pelaajan_kortti2;
    return palautettava;
}

string jaa_vastustajan_kortit(){
    int random_luku1 = random.Next(0,50);
    string vastustajan_kortti1 = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    int random_luku2 = random.Next(0,49);
    string vastustajan_kortti2 = kortit_listana[random_luku2];
    kortit_listana.RemoveAt(random_luku2);
    string palautettava = vastustajan_kortti1+vastustajan_kortti2;
    return palautettava;
}

void sekoita(){
    kortit_listana = new List<string>(kortit);
}

int kortti_luvuksi(string kortti){
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
int onko_vari(string pelaaja,string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
    
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
            //Console.WriteLine("testi");
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
        //Console.WriteLine("testi");
        foreach(string kortti in lista){
            
            if(pelaaja == "mina" && kortti[1] == 'd'){
               Console.WriteLine($"listaan pistettavat kortit: {kortti} ");
                kickeri.Add(kortti_luvuksi(kortti));
                
            } else if(pelaaja == "tietokone"){
                if(kortti[1] == 'd'){
                    tietokoneen_kickeri.Add(kortti_luvuksi(kortti));
                }
            }
        }
        if(isoin_d == 14){
            Console.WriteLine("väri: ässä hai");
        } else if(isoin_d == 13){
            Console.WriteLine("väri: kuningas hai");
        } else if(isoin_d == 12){
            Console.WriteLine("väri: rouva hai");
        } else if(isoin_d == 11){
            Console.WriteLine("väri: jätkä hai");
        } else{
            Console.WriteLine($"väri {isoin_d} hai");
        }
        if(kickeri.Any() && pelaaja == "mina"){
            Console.WriteLine($"tämä on olevinaan max: {kickeri.Max()}");
            kickeri.Remove(kickeri.Max());
        } if(tietokoneen_kickeri.Any() && pelaaja=="tietokone"){
            tietokoneen_kickeri.Remove(tietokoneen_kickeri.Max());
        }
        
        
        return isoin_d;
    } else if(heart > 4){
        foreach(string kortti in lista){
            if(kortti[1] == 'h' && pelaaja == "mina"){
                
                kickeri.Add(kortti_luvuksi(kortti));
            } else if(kortti[1] == heart && pelaaja =="tietokone"){
                tietokoneen_kickeri.Add(kortti_luvuksi(kortti));
            }
        }
          if(isoin_h == 14){
            Console.WriteLine("väri: ässä hai");
        } else if(isoin_h == 13){
            Console.WriteLine("väri: kuningas hai");
        } else if(isoin_h == 12){
            Console.WriteLine("väri: rouva hai");
        } else if(isoin_h == 11){
            Console.WriteLine("väri: jätkä hai");
        } else{
            Console.WriteLine($"väri {isoin_h} hai");
        }
        if(kickeri.Any() && pelaaja == "mina"){
            kickeri.Remove(kickeri.Max());
        } if(tietokoneen_kickeri.Any() && pelaaja=="tietokone"){
            tietokoneen_kickeri.Remove(tietokoneen_kickeri.Max());
        }
        return isoin_h;
    } else if(spade > 4){
        foreach(string kortti in lista){
            if(kortti[1] == 's' && pelaaja == "mina"){
                kickeri.Add(kortti_luvuksi(kortti));
            } else if(kortti[1] == 's' && pelaaja =="tietokone"){
                tietokoneen_kickeri.Add(kortti_luvuksi(kortti));
            }
        }
          if(isoin_s == 14){
            Console.WriteLine("väri: ässä hai");
        } else if(isoin_s == 13){
            Console.WriteLine("väri: kuningas hai");
        } else if(isoin_s == 12){
            Console.WriteLine("väri: rouva hai");
        } else if(isoin_s == 11){
            Console.WriteLine("väri: jätkä hai");
        } else{
            Console.WriteLine($"väri {isoin_s} hai");
        }
        if(kickeri.Any() && pelaaja == "mina"){
            kickeri.Remove(kickeri.Max());
        } if(tietokoneen_kickeri.Any() && pelaaja=="tietokone"){
            tietokoneen_kickeri.Remove(tietokoneen_kickeri.Max());
        }
        return isoin_s;
    } else if(club > 4){
        foreach(string kortti in lista){
            if(kortti[1] == 'c' && pelaaja == "mina"){
                kickeri.Add(kortti_luvuksi(kortti));
            } else if(kortti[1] == 's' && pelaaja =="tietokone"){
                tietokoneen_kickeri.Add(kortti_luvuksi(kortti));
            }
        }
          if(isoin_c == 14){
            Console.WriteLine("väri: ässä hai");
        } else if(isoin_c == 13){
            Console.WriteLine("väri: kuningas hai");
        } else if(isoin_c == 12){
            Console.WriteLine("väri: rouva hai");
        } else if(isoin_c == 11){
            Console.WriteLine("väri: jätkä hai");
        } else{
            Console.WriteLine($"väri {isoin_c} hai");
        }
        if(kickeri.Any() && pelaaja == "mina"){
            kickeri.Remove(kickeri.Max());
        } if(tietokoneen_kickeri.Any() && pelaaja == "tietokone"){
            tietokoneen_kickeri.Remove(tietokoneen_kickeri.Max());
        }
        return isoin_c;
    } else{
        return 0;
    }
}
int onko_suora(int pelaajan_kortti1, int pelaajan_kortti2, int floppi1, int floppi2, int floppi3, int turn, int river){
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
            //Console.WriteLine(suoran_laskuri);
            //Console.WriteLine(kuinka_suuri_suora.Max());
        } else{
            suoran_laskuri = 0;
            kuinka_suuri_suora.Clear();
        }
        if(suoran_laskuri == 4){
            if(kuinka_suuri_suora.Max() == 14){
                Console.WriteLine($"Suora: ässä hai");
            } else if(kuinka_suuri_suora.Max() == 13){
                Console.WriteLine($"Suora: kuningas hai");
            } else if(kuinka_suuri_suora.Max() == 12){
                Console.WriteLine($"Suora: rouva hai");
            } else if(kuinka_suuri_suora.Max() == 11){
                Console.WriteLine($"Suora: jätkä hai");
            } else{
                Console.WriteLine($"Suora: {kuinka_suuri_suora.Max()} hai");
            }
            return kuinka_suuri_suora.Max();
        } else if(kortit_jarjestyksessa.Contains(14) && kortit_jarjestyksessa.Contains(2) && kortit_jarjestyksessa.Contains(3) && kortit_jarjestyksessa.Contains(4) && kortit_jarjestyksessa.Contains(5) && !kortit_jarjestyksessa.Contains(6) && suoran_laskuri == 0){
            Console.WriteLine($"Suora: 5 hai");
            return 5;
        }
            
        }
        return 0;
    }

    int onko_pari(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        kickeri.Clear();
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
            Console.WriteLine($"Pelaajalla on yksi pari {parit_listassa[0]} {parit_listassa[1]}, kickerillä {isoin_kortti}");
            return kortin_arvo;
        } else{
        return 0;
        }
        
    }

    List<string> onko_kaksi_paria(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        kickeri.Clear();
        List<string> korttiArray = new List<string> {pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
        List<int> parit = new List<int>{};
        List<string> parit_kortteina = new List<string>{};
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
        if(onko_pari == 4){
            
            parit.Sort();
            parit_kortteina.Sort();
            Console.WriteLine($"Pelaajalla on kaksi paria, {parit_kortteina[0]} {parit_kortteina[1]} ja {parit_kortteina[2]} {parit_kortteina[3]} kickerillä {isoin_kortti}");
            return parit_kortteina;
        } else{
        return null;
        }
        
    }
    int vertaile_kickereita(List<int> lista1, List<int> lista2){
        lista1.Sort();
        lista2.Sort();
        
        for(int i = lista1.Count-1; i>=0;i--){
            Console.WriteLine(lista1[i]);
            Console.WriteLine(lista2[i]);
            if(lista1[i] > lista2[i]){
                Console.WriteLine($"Pelaaja voittaa kickerillä {lista1[i]}");
                return 1;
            } else if(lista2[i] > lista1[i]){
                Console.WriteLine($"Tietokone voittaa kickerillä {lista2[i]}");
                return 2;
            }
        }
        return 0;

    }
    int onko_kolmoset(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<string> kortit = new List<string>{pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
        kickeri.Clear();
        List<string> parilliset_kortit = new List<string>();
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
            Console.WriteLine($"Pelaajalla on kolmoset: {parilliset_kortit[0]} {parilliset_kortit[1]} {parilliset_kortit[2]} ");
            return kortti_luvuksi(parilliset_kortit[0]);
        } else{
            return 0;
        }
    }

    int onko_tayskasi(string pelaaja,string kortti1, string kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<string> lista = new List<string>{kortti1, kortti2, floppi1, floppi2, floppi3, turn, river};
        List<string> tayskasi = new List<string>();
        List<string> kolmoset = new List<string>();
        List<string> pari = new List<string>();
        string kortti = "";
        int indeksi = 0;
        int kuinka_monta_korttia = 0;
        while(indeksi < lista.Count){
            for(int j = 0; j< lista.Count; j++){
                if(lista[indeksi][0] == lista[j][0] && !tayskasi.Contains(lista[indeksi]) && lista[indeksi] != lista[j]){
                    tayskasi.Add(lista[indeksi]);
                    //Console.WriteLine(lista[indeksi]);
                    //Console.WriteLine("testi");
                }
            }
            indeksi++;
        }
        //Console.WriteLine(tayskasi.Count);
        
        string testataan_korttia = "";
        if(tayskasi.Count == 5){
            tayskasi.Sort();
            if(tayskasi[0][0] == tayskasi[1][0] && tayskasi[0][0] != tayskasi[2][0]){
                pari.Add(tayskasi[0]);
                kolmoset.Add(tayskasi[2]);
                Console.WriteLine($"Pelaajalla täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                return kortti_luvuksi(kolmoset[0]);
            } else if(tayskasi[0][0] == tayskasi[2][0]){
                kolmoset.Add(tayskasi[0]);
                pari.Add(tayskasi[3]);
                Console.WriteLine($"Pelaajalla on täyskäsi, {kolmoset[0][0]} täynnä {pari[0][0]}");
                return kortti_luvuksi(kolmoset[0]);
            }
        }
           return 0;         
        }
                
            
            
            

         
    
    
    /*string pelaajan_korit = jaa_pelaajan_kortit();
    string vastustajan_kortit = jaa_vastustajan_kortit();
    string pelaajan_kortti_eka = pelaajan_korit.Substring(0,2);
    string pelaajan_kortti_toka = pelaajan_korit.Substring(2,2);
    string vastustajan_kortti_eka = vastustajan_kortit.Substring(0,2);
    string vastustajan_kortti_toka = vastustajan_kortit.Substring(2,2);
    string floppi = jaa_floppi();
    string floppi1 = floppi.Substring(0,2);
    string floppi2 = floppi.Substring(2,2);
    string floppi3 = floppi.Substring(4,2);
    Console.WriteLine($"Pelaajan kortit: {pelaajan_kortti_eka} {pelaajan_kortti_toka}");
    Console.WriteLine($"Vastustajan kortit: {vastustajan_kortti_eka} {vastustajan_kortti_toka}");
    Console.WriteLine($"{floppi1} {floppi2} {floppi3} {jaa_turni()} {jaa_riveri()}");
    sekoita();
    */
    Console.WriteLine("Pelaajan käsi: ");
    int moi = onko_tayskasi("mina","2c","3h","Qc","Qs", "3s", "Kc","Qd");
    Console.WriteLine(moi);
    
    //int moi2 = onko_vari("tietokone","5d","3h","Jd","9h","Td","4d", "Qd");
    //Console.WriteLine(moi2);
    //int kumpi_voitti = vertaile_kickereita(kickeri,tietokoneen_kickeri);
    //Console.WriteLine(kumpi_voitti);
    
