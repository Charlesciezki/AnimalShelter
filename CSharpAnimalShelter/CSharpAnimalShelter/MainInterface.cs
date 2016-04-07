using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace CSharpAnimalShelter
{
    public class MainInterface
    {
        public AnimalShelter TheAnimalShelter = new AnimalShelter();
        public Cage TheCages = new Cage();
        public int menuChoice;
        public MainInterface()
        {
            TheAnimalShelter.SpawnAdoptors();
            TheAnimalShelter.SpawnCats();
            TheAnimalShelter.SpawnDogs();
        }

        public int MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the animal shelters' main menu!");
            Console.WriteLine("Enter 1 to Add an animal to the system");
            Console.WriteLine("Enter 2 to remove animal from the system");
            Console.WriteLine("Enter 3 to check the system");
            Console.WriteLine("Enter 4 to feed an animal");
            Console.WriteLine("Enter 5 to give an animal medicine");
            Console.WriteLine("Enter 6 fill out adoption papers");
            Console.WriteLine("Enter 7 to get approved to adopt!");
            Console.WriteLine("Enter 8 to select the animal you wish to adopt");
            Console.WriteLine("Enter 9 to check Animal Shelter Funds");
            Console.WriteLine("Enter 10 to EXIT");

            bool MainMenuMistakeCatcher = Int32.TryParse(Console.ReadLine(), out menuChoice);
            if (MainMenuMistakeCatcher == false)
            {
                return MainMenu();
            }

            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    TheAnimalShelter.ChooseAnimalToAdd();
                    break;
                case 2:
                    Console.Clear();
                    TheAnimalShelter.ChooseAnimalToRemove();
                    break;
                case 3:
                    Console.Clear();
                    TheAnimalShelter.CheckTheSystem();
                    break;
                case 4:
                    Console.Clear();
                    TheAnimalShelter.FeedAnimal();
                    break;
                case 5:
                    Console.Clear();
                    TheAnimalShelter.GiveShots();
                    break;
                case 6:
                    Console.Clear();
                    TheAnimalShelter.FillOutAdoptionForm();
                    break;
                case 7:
                    Console.Clear();
                    TheAnimalShelter.ApproveAdoption();
                    break;
                case 8:
                    Console.Clear();
                    TheAnimalShelter.AdoptAnimal();
                    break;
                case 9:
                    Console.Clear();
                    TheAnimalShelter.CheckAnimalShelterFunds();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Bye-bye!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;

            }
            return 1;
        }
    }
}
