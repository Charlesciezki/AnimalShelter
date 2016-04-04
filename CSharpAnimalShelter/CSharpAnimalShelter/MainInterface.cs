using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimalShelter
{
    public class MainInterface
    {
        public int menuChoice;
        public MainInterface()
        {
//AddAnimal

//RemoveAnimal
//See Animals List

//Fill out Adoption papers


//AdoptAnimal




// FeedAnimals

//Give Animals Shots
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to the animal shelters' main menu!");
            Console.WriteLine("Enter 1 to Add an animal to the system");
            Console.WriteLine("Enter 2 to remove animal from the system");
            Console.WriteLine("Enter 3 to check the system");
            Console.WriteLine("Enter 4 to feed an animal");
            Console.WriteLine("Enter 5 to give an animal medicine");
            Console.WriteLine("Enter 6 fill out adoption papers");
            Console.WriteLine("Enter 7 to select the animal you wish to adopt");

            menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                default:
                    MainMenu();
                    break;

            }

        }
    }
}
