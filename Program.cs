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

void onko_suora(string kortit, string floppi, string turn, string river){
    

}