namespace NLHEFLIPPING;

public class Pakka{
    Random random = new Random();
    public Kortit kortit;
    public List<string> kortit_listana;

    public string jaa_floppi(){
        int random_luku1 = random.Next(0,48);
        string flopin_eka_kortti = kortit_listana[random_luku1];
        kortit_listana.RemoveAt(random_luku1);
        int random_luku2 = random.Next(0,47);
        string flopin_toinen_kortti = kortit_listana[random_luku2];
        kortit_listana.RemoveAt(random_luku2);
        int random_luku3 = random.Next(0,46);
        string flopin_kolmas_kortti = kortit_listana[random_luku3];
        string palautettava = flopin_eka_kortti + flopin_toinen_kortti + flopin_kolmas_kortti;
        kortit_listana.RemoveAt(random_luku3);
        return palautettava;
}
    public string jaa_turni(){
    int random_luku1 = random.Next(0,45);
    string turni = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    return turni;
}
    public string jaa_riveri(){
    int random_luku1 = random.Next(0,44);
    string riveri = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    return riveri;
}
    public string jaa_pelaajan_kortit(){
    int random_luku1 = random.Next(0,52);
    string pelaajan_kortti1 = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    int random_luku2 = random.Next(0,51);
    string pelaajan_kortti2 = kortit_listana[random_luku2];
    kortit_listana.RemoveAt(random_luku2);
    string palautettava = pelaajan_kortti1 + pelaajan_kortti2;
    return palautettava;
}

    public string jaa_vastustajan_kortit(){
    int random_luku1 = random.Next(0,50);
    string vastustajan_kortti1 = kortit_listana[random_luku1];
    kortit_listana.RemoveAt(random_luku1);
    int random_luku2 = random.Next(0,49);
    string vastustajan_kortti2 = kortit_listana[random_luku2];
    kortit_listana.RemoveAt(random_luku2);
    string palautettava = vastustajan_kortti1+vastustajan_kortti2;
    return palautettava;
}
    public Pakka(Kortit _kortit){
        kortit = _kortit;
        kortit_listana = new List<string>(Kortit.korttipakka);
                      
    
    }
    
}



