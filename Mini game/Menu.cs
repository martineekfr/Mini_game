namespace Mini_game;

public class Menu : Gameplay
{
    public static bool Menu_smicka = true;
    public static string Exit_message = "Hra se ukoncuje";

    public Menu(bool menu_smicka, string exit_message) 
    {
        Menu_smicka = menu_smicka;
        Exit_message = exit_message;
    }
    

    public static async Task Start()
    {
        while (Menu_smicka)
        {
            List<string> options = new List<string> { "start game", "exit" };
            int choice = InputHelper.ShowMenu(options, "\n Welcome to Mini Game! ");
            Console.Clear();

            switch (choice)
            {
                case 0:
                    await Game();
                    break;
                case 1:
                    Console.WriteLine(Exit_message);
                    Menu_smicka = false;
                    break;
            }
        }
    }
}