using System.Reflection.Metadata;

namespace Mini_game;

public class Monsters_Class
{
    string Monster;
    public int Monster_hp;

    public Monsters_Class(string monster, int monster_hp)
    {
        Monster = monster;
        Monster_hp = monster_hp;
    }
    
   static List<string> names = ["Karel", "Kresomira", "Damian", "MJ"]; // list s nazvy monster. bude se nahodne losovat jmeno a hp monstra
   static Random rnd = new Random(); // generator
   static string randomName = names[rnd.Next(names.Count)]; //generovani random cisla

   static List<int> Hp = [50, 75, 100, 125, 150]; // list s cisly 
   static Random rnd2 = new Random(); // generator 2.0
   static int randomHp = Hp[rnd.Next(Hp.Count)];
    

    Monsters_Class monstrum = new Monsters_Class(randomName, randomHp);

    public List<Monsters_Class> Monstra = new List<Monsters_Class>();
    
    public Monsters_Class Monster_Attack() // Zahaji interakci s nahodnym monstrem 
    {
        Console.WriteLine("Monstrum: " +  monstrum.Monster + "Hp: " + monstrum.Monster_hp + "\n Vyber jak chces pokracovat: " +
                          "\n 1) zautocit " +
                          "\n 2) utect");
        
        int choice2 = int.Parse(Console.ReadLine());
        
        
        
        
    }
    
    
}