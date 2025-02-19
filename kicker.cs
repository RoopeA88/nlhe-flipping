namespace NLHEFLIPPING;

class Kicker{
    public int vertaile_kickereita(List<int> lista1, List<int> lista2){
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
        Console.WriteLine("Tasapeli!");
        return 0;

    }
}