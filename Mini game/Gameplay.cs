namespace Mini_game;


public class Gameplay
{ 
    public static async Task Game()
    {
        string Uvodni_text = "Jsi na skolnim vylete a najednou zahlednes jeskyni. " +
                             "Tak se tam rozhodnes vydat po par hodinach hledani, " +
                             "najdes takovou velkou mistnost a vni monstra.";
        foreach (char znak in Uvodni_text)
        {
            Console.Write(znak);
            await Task.Delay(90);
        }
        
        List<string> names = ["Karel Hp:", "Kresomira Hp:", "Damian Hp:", "MJ Hp:"]; // list s nazvy monster. bude se nahodne losovat jmeno a hp monstra
        Random rnd = new Random(); // generator
        string randomName = names[rnd.Next(names.Count)]; //generovani random cisla

        List<int> Hp = [50, 75, 100, 125, 150]; // list s cisly 
        Random rnd2 = new Random(); // generator 2.0
        int randomHp = Hp[rnd2.Next(Hp.Count)];
   
        Monsters_Class monstrum = new Monsters_Class(randomName, randomHp); // vytvari monstrum z generatoru
        
        monstrum.Fight(); // spusti metodu Fight s hodnotama mosnstra, ktere bylo predtim vygenerovane
        
    }
}