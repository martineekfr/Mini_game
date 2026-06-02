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
            Console.WriteLine("\n Welcome to Mini Game! \n 1) start game \n 2) exit");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    await Game();
                    break;
                case 2:
                    Console.WriteLine(Exit_message);
                    Menu_smicka = false;
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
    }
}