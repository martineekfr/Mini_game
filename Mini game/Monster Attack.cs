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

    public Monsters_Class Fight() // Zahaji interakci s nahodnym monstrem 
    {
        int pouziti1 = 10;
        int pouziti2 = 5;
        int pouziti3 = 1;
        while (Monster_hp > 0)
        {
            Console.WriteLine($"Jaky utok ches pouzit? \n" + // vyber utoku
                              $"1) pest{pouziti1} \n" +
                              $"2) kamen{pouziti2} \n" +
                              $"3) sekyra{pouziti3} \n" +
                              "4) utect");
            int choice3 = int.Parse(Console.ReadLine());
            switch (choice3)
            {
                case 1:
                    Console.WriteLine("pest");
                    Player p = new Player(100);
                    pest();
                    pouziti1--;
                    break;
            }
        }
        Console.WriteLine("Porazil jsi :");
        return new Monsters_Class(Monster_name, Monster_hp);
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