// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Configuration.Assemblies;
Random random = new Random();

string [] kortit = new string[]{"Ah","2h","3h","4h","5h","6h","7h","8h","9h","Th","Jh","Qh","Kh",
                                "Ad","2d","3d","4d","5d","6d","7d","8d","9d","Td","Jd","Qd","Kd",
                                "As","2s","3s","4s","5s","6s","7s","8s","9s","Ts","Js","Qs","Ks",
                                "Ac","2c","3c","4c","5c","6c","7c","8c","9c","Tc","Jc","Qc","Kc"};

List<string> kortit_listana = new List<string>(kortit);


string pelaajan_kortti1;
string pelaajan_kortti2;

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
int onko_vari(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
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
    if(diamond >4){
        return isoin_d;
    } else if(heart > 4){
        return isoin_h;
    } else if(spade > 4){
        return isoin_s;
    } else if(club > 4){
        return isoin_c;
    } else{
        return 0;
    }
}
int onko_suora(int pelaajan_kortti1, int pelaajan_kortti2, int floppi1, int floppi2, int floppi3, int turn, int river){
    int suoran_laskuri = 0;
    List<int> kuinka_suuri_suora = new List<int>();
    int [] jarjesta_kortit = new int[]{pelaajan_kortti1,pelaajan_kortti2,floppi1,floppi2,floppi3,turn,river};
    jarjesta_kortit = jarjesta_kortit.Distinct().ToArray();
    Array.Sort(jarjesta_kortit);
    for(int i = jarjesta_kortit.Length-1; i > 0; i--){
        if(jarjesta_kortit[i-1] == jarjesta_kortit[i]-1){
            suoran_laskuri++;
            kuinka_suuri_suora.Add(jarjesta_kortit[i]);
        } else{
            suoran_laskuri = 0;
            kuinka_suuri_suora.Clear();
        }
        if(suoran_laskuri == 4){
            return kuinka_suuri_suora.Max();
        }
            
        }
        return 0;
    }

    int onko_pari(string pelaajan_kortti1, string pelaajan_kortti2, string floppi1, string floppi2, string floppi3, string turn, string river){
        List<string> korttiArray = new List<string> {pelaajan_kortti1, pelaajan_kortti2, floppi1, floppi2, floppi3, turn, river};
        int indeksi = 0;
        int onko_pari = 0;
        int kortin_arvo = 0;
        
        
        while(indeksi <korttiArray.Count){
            foreach(string kortti in korttiArray){
                if(korttiArray[indeksi][0] == kortti[0] && korttiArray[indeksi] != kortti){
                    onko_pari++;
                    
                    kortin_arvo = (int)char.GetNumericValue(kortti[0]);
                    return kortin_arvo;
                    
                }
            }
            indeksi++;
        }
        return 0;
        
    }

    int testi = onko_pari("Ah","Jh","7d","6c","2h","Kc","7c");
    Console.WriteLine(testi);
    
