namespace Mini_game;


public class Gameplay
{ 
    public static async Task Game()
    {
        string Uvodni_text = "Jsi se skolou na vylete. Kdyz prochazite kolem jedne skaly, tak vni zahlednete takovy vchod. " +
                             "Po chvili premysleni se rozhodnes se do ni vydat. Po par minutach hledani najdes temnou mistnost." +
                             "Kdyz do ni vstoupis, tak na tebe najednou z temneho rohu vybehne montrum";
        foreach (char znak in Uvodni_text)
        {
            Console.Write(znak);
            await Task.Delay(90);
        }
        
        List<string> names = ["Karel", "Kresomira", "Damian", "MJ"]; // list s nazvy monster. bude se nahodne losovat jmeno a hp monstra
        Random rnd = new Random(); // generator
        string randomName = names[rnd.Next(names.Count)]; //generovani random cisla

        List<int> Hp = [150, 200, 250, 300, 500]; // list s cisly 
        Random rnd2 = new Random(); // generator 2.0
        int randomHp = Hp[rnd2.Next(Hp.Count)];
   
        Monsters_Class monstrum = new Monsters_Class(randomName, randomHp); // vytvari monstrum z generatoru
        
        Console.Clear();
        monstrum.Fight(); // spusti metodu Fight s hodnotama mosnstra, ktere bylo predtim vygenerovane
        
    }
}