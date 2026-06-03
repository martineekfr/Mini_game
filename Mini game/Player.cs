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
        List<int> attack_damage = new List<int>([10, 20, 30, 40, 50]);
        Random _random = new Random();
        int damage = attack_damage[_random.Next(attack_damage.Count)];
        Hrac_hp -= damage;
        Console.WriteLine($"Dostal jsi {damage} damage.");
    }

    public void Heal()
    {
        Hrac_hp += 50;
    }
}