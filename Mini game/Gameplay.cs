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
            await Task.Delay(50);
        }
        
    }
}