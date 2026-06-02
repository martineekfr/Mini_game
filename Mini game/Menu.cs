namespace Mini_game;

public class Menu : Gameplay
{
    private bool Menu_smicka = true;
    public string Exit_message = "Hra se ukoncuje";

    public Menu(bool menu_smicka, string exit_message) 
    {
        Menu_smicka = menu_smicka;
        Exit_message = exit_message;
    }
    

    public void Start()
    {
        while (Menu_smicka)
        {
            Console.WriteLine("Welcome to Mini Game! \n 1) start game \n 2) exit");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Game();
                    break;
                case 2:
                    Menu_smicka = false;
                    break;
            }
        }
    }
}