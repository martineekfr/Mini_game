using System.Reflection.Metadata;

namespace Mini_game;

public class Monsters_Class
{
    string Monster_name;
    public int Monster_hp;

    public Monsters_Class(string monster_name, int monster_hp)
    {
        Monster_name = monster_name;
        Monster_hp = monster_hp;
    }
    
    static List<string> names = ["Karel Hp:", "Kresomira Hp:", "Damian Hp:", "MJ Hp:"]; // list s nazvy monster. bude se nahodne losovat jmeno a hp monstra
    static Random rnd = new Random(); // generator
    static string randomName = names[rnd.Next(names.Count)]; //generovani random cisla

    static List<int> Hp = [50, 75, 100, 125, 150]; // list s cisly 
    static Random rnd2 = new Random(); // generator 2.0
    static int randomHp = Hp[rnd.Next(Hp.Count)];
   
    static Monsters_Class monstrum = new Monsters_Class(randomName, randomHp);
    
   
    
    public static Monsters_Class Monster_Attack() // Zahaji interakci s nahodnym monstrem 
    {
        
        int choice2 = int.Parse(Console.ReadLine());
        string zabiti_message = "Zabili jste monstrum prejete si pokracoavt";

        switch (choice2)
        {
            case 1:
                Console.WriteLine("Jaky utok ches pouzit? \n" +
                                  "1) pest \n" +
                                  "2) kamen \n" +
                                  "3) utect");
                int choice3 = int.Parse(Console.ReadLine());
                switch (choice3)
                {
                    case 1:
                        Console.WriteLine("utok");
                        return monstrum;

                        break;
                }
                break;
            
        }
        Console.WriteLine("Porazil jsi :");
        return monstrum;
        

    }
    
    
}