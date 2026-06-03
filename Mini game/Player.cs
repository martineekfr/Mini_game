namespace Mini_game;

public class Player
{
    int Hrac_hp;

    public Player(int hrac_hp)
    {
        Hrac_hp = hrac_hp;
    }

    static List<int> attack_damage = new List<int>([10, 20, 30, 40, 50]);
    static Random _random = new Random();
    int damage = attack_damage[_random.Next(attack_damage.Count)];

    public void TakeDamage()
    {
        Hrac_hp -= damage;
    }

    public void Heal()
    {
        Hrac_hp += 10;
    }
}