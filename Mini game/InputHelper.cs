using System;
using System.Collections.Generic;

namespace Mini_game
{
    public static class InputHelper
    {
        public static int ShowMenu(List<string> options, string prompt = null)
        {
            int selectedIndex = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();
                if (!string.IsNullOrEmpty(prompt))
                {
                    Console.WriteLine(prompt);
                }

                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine($"  {options[i]}  ");
                }
                Console.ResetColor();

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Count - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Count)
                        selectedIndex = 0;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}