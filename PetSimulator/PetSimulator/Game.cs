using System;
using System.Collections.Generic;

namespace Empty_repo
{
    public class Game
    {
        private bool isRunning = true;

        public void Start()
        {
            Console.WriteLine(" Welcome to the Pet Simulator ");
            Console.WriteLine("Welcome to the ultimate simulator of taking care of a pet friend!");
            Console.WriteLine();

            var menu = new Menu(new List<string>
            {
                "Adopt a Pet",
                "Show All Pets",
                "Credits",
                "Exit Game"
            });

            while (isRunning)
            {
                menu.Show();
                int choice = menu.GetChoice();

                switch (choice)
                {
                    case 1:
                        AdoptPet();
                        break;
                    case 2:
                        ShowAllPets();
                        break;
                    case 3:
                        ShowCreatorInfo();
                        break;
                    case 4:
                        ExitGame();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
            }
        }

        private void AdoptPet()
        {
            Console.WriteLine("[Pet adoption screen will be implemented soon]");
        }

        private void ShowAllPets()
        {
            Console.WriteLine("[Pet list and stats will be shown here]");
        }

        private void ShowCreatorInfo()
        {
            Console.WriteLine("Created by: Emir Yalçın | Student Number: 2305041032");
        }

        private void ExitGame()
        {
            Console.WriteLine("Exiting the game. Thank you for playing! Don't forget to come back soon for your pet friends !");
            isRunning = false;
        }
    }
}
