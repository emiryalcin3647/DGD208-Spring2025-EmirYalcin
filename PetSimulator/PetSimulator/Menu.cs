using System;
using System.Collections.Generic;

namespace Empty_repo
{
    public class Menu
    {
        private List<string> options;

        public Menu(List<string> menuOptions)
        {
            options = menuOptions;
        }

        public void Show()
        {
            Console.WriteLine("=== MAIN MENU ===");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
            Console.Write("Enter your choice: ");
        }

        public int GetChoice()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Count)
            {
                return choice;
            }

            Console.WriteLine("Please enter a valid selection.");
            return -1;
        }
    }
}
