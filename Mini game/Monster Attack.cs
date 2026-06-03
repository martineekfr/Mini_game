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

    Player p = new Player(150);

    public Monsters_Class Fight() // Zahaji interakci s nahodnym monstrem 
    {
        int pouziti1 = 10;
        int pouziti2 = 5;
        int pouziti3 = 1;
        int pouziti4 = 3;
        while (Monster_hp > 0 && p.Hrac_hp > 0)
        {
            Console.WriteLine($"\n {Monster_name} {Monster_hp} hp | Hrac {p.Hrac_hp}" +
                              $"\nJaky utok ches pouzit? \n" + // vyber utoku
                              $"1) pest {pouziti1} left \n" +
                              $"2) kamen {pouziti2} left \n" +
                              $"3) sekyra {pouziti3} left \n" +
                              $"4) heal {pouziti4} left \n" +
                              "5) utect \n");
            int choice3 = int.Parse(Console.ReadLine());
            switch (choice3)
            {
                case 1:
                    if (pouziti1 == 0)
                    {
                        Console.WriteLine("utok ti dosel");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("UTOK PESTIIII!!!!");
                        pest();
                        Console.WriteLine($"Odebral jsi 10 hp monstru.");
                        p.TakeDamage();
                        pouziti1--;
                    }
                    break;
                
                case 2:
                    if (pouziti1 == 0)
                    {
                        Console.WriteLine("utok ti dosel");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("UTOK KAMENEEEEEM!!!!");
                        kamen();
                        Console.WriteLine($"Odebral jsi 20 hp monstru.");
                        p.TakeDamage();
                        pouziti2--;
                    }
                    break;
                
                case 3:
                    if (pouziti1 == 0)
                    {
                        Console.WriteLine("utok ti dosel");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("UTOK SEKYROUUU!!!!");
                        sekyra();
                        Console.WriteLine($"Odebral jsi 100 hp monstru.");
                        p.TakeDamage();
                        pouziti3--;
                        
                    }
                    break;
                case 4:
                    if (pouziti1 == 0)
                    {
                        Console.WriteLine("heal ti dosel");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Byl jsi healnut!!!");
                        p.Heal();
                        pouziti4--;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("z boje se neutika!!");
                    break;
                    
                    
                    
            }
        }

        if (Monster_hp <= 0)
        {
            Console.Clear();
            Console.WriteLine("Vyhral jsi!!");
        }
        else if (p.Hrac_hp <= 0)
        {
            Console.Clear();
            Console.WriteLine("Prohral jsi zkus to znovu");
            
        }
        return this;

    }

    public void pest()
    {
        Monster_hp -= 10;
    }

    public void kamen()
    {
        Monster_hp -= 20;
    }

    public void sekyra()
    {
        Monster_hp -= 100;
    }


}