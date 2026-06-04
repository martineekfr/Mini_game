namespace Mini_game;

public class Player
{
    public int Hrac_hp;
   

    public Player(int hrac_hp)
    {
        Hrac_hp = hrac_hp;
        
    }
    

    public void TakeDamage()
    {
        List<int> attack_damage = new List<int>([30,40,50,60,70,80,90,100]);
        Random _random = new Random();
        int damage = attack_damage[_random.Next(attack_damage.Count)];
        Hrac_hp -= damage;
        Console.WriteLine($"Dostal jsi {damage} damage.");
    }

    public void Heal()
    {
        if (Hrac_hp > 130)
        {
            Hrac_hp = 200;
        }
        else
        {
            Hrac_hp += 70;
        }
    }
}