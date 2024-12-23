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

