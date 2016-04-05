using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpAnimalShelter
{
    public class AnimalShelter
    {
        public List<List<Animal>> listOfCages = new List<List<Animal>>();
        public List<Animal> listOfCats = new List<Animal>();
        public List<Animal> listOfDogs = new List<Animal>();
        public List<AdoptionCanidate> ListOfAdoptionCanidates = new List<AdoptionCanidate>();
        Random random = new Random();
        public bool hasHadShot;
        public bool hasBeenFed;

        public AnimalShelter()
        {
            listOfCages.Add(listOfCats);
            listOfCages.Add(listOfDogs);
        }

        public int ChooseAnimalToAdd()
        {
            Console.WriteLine("Enter 1 to add a dog");
            Console.WriteLine("Enter 2 to add a cat");
            int whichAnimal;
            bool MistakeCatcher = Int32.TryParse(Console.ReadLine(), out whichAnimal);
            if (MistakeCatcher == false)
            {
                return ChooseAnimalToAdd();
            }
            switch (whichAnimal)
            {
                case 1:
                    AddDog();
                    break;
                case 2:
                    AddCat();
                    break;
                default:
                    ChooseAnimalToAdd();
                    break;
            }
            return 1;
        }

        public int ChooseAnimalToRemove()
        {
            Console.WriteLine("Enter 1 to add a dog");
            Console.WriteLine("Enter 2 to add a cat");
            int whichAnimal;
            bool MistakeCatcher = Int32.TryParse(Console.ReadLine(), out whichAnimal);
            if (MistakeCatcher == false)
            {
                return ChooseAnimalToRemove();
            }
            switch (whichAnimal)
            {
                case 1:
                    RemoveDog();
                    break;
                case 2:
                   RemoveCat();
                    break;
                default:
                    ChooseAnimalToRemove();
                    break;
            }
            return 1;
        }

        public bool HasHadShots()
        {

            int shotChoice = random.Next(0, 2);
            if (shotChoice == 0)
            {
                hasHadShot = true;
            }
            else if (shotChoice == 1)
            {
                hasHadShot = false;
            }
            return hasHadShot;
        }

        public bool HasBeenFed()
        {
            int fedChoice = random.Next(0, 2);
            if (fedChoice == 0)
            {
                hasBeenFed = true;
            }
            else if (fedChoice == 1)
            {
                hasBeenFed = false;
            }
            return hasBeenFed;
        }

        public void AddCat()
        {
            Console.WriteLine("What's the cats name?");
            string catName = Console.ReadLine();
            Console.WriteLine("And the breed of cat?");
            string catBreed = Console.ReadLine();

            HasHadShots();
            HasBeenFed();

            CatClass cat = new CatClass(random.Next(0, 9), random.Next(100, 351), hasHadShot, hasBeenFed, catName,
                catBreed);
            listOfCages[0].Add(cat);
            Console.WriteLine("You have " + listOfCages[0].Count + " cats");
        }

        public void RemoveCat()
        {

        }

        public void AddDog()
        {
            Console.WriteLine("What's the dogs name?");
            string dogName = Console.ReadLine();
            Console.WriteLine("And the breed of dog?");
            string dogBreed = Console.ReadLine();

            HasHadShots();
            HasBeenFed();

            DogClass dog = new DogClass(random.Next(0, 9), random.Next(100, 951), hasHadShot, hasBeenFed, dogName,
                dogBreed);
            listOfCages[1].Add(dog);
            Console.WriteLine("You have " + listOfCages[1].Count + " dogs");
        }

        public void RemoveDog()
        {

        }

        public int GiveShots()
        {
            Console.WriteLine("Enter 1 to give shots to all cats that need them");
            Console.WriteLine("Enter 2 to give shots to all dogs that need them");
            int ShotsChoice;
            bool MistakeCatcher = Int32.TryParse(Console.ReadLine(), out ShotsChoice);
            if (MistakeCatcher == false)
            {
                return GiveShots();
            }
            switch (ShotsChoice)
            {
                case 1:
                    GiveCatsShots();
                    break;
                case 2:
                    GiveDogsShots();
                    break;
            }
            return 1;
        }

        public void GiveCatsShots()
        {
            for (int i = 0; i < listOfCages[0].Count; i++)
            {
                if (listOfCages[0][i].HasShots != true)
                {
                    listOfCages[0][i].HasShots = true;
                }
            }
            Console.WriteLine("The cats have been given their shots!");
            Console.ReadLine();
        }

        public void GiveDogsShots()
        {
            for (int i = 0; i < listOfCages[1].Count; i++)
            {
                if (listOfCages[1][i].HasShots != true)
                {
                    listOfCages[1][i].HasShots = true;
                }
            }
            Console.WriteLine("The dogs have been given their shots!");
            Console.ReadLine();
        }

        public int FeedAnimal()
        {
            Console.WriteLine("Enter 1 to feed all cats that are hungry");
            Console.WriteLine("Enter 2 to feed all dogs that are hungry");
            int FeedChoice;
            bool MistakeCatcher = Int32.TryParse(Console.ReadLine(), out FeedChoice);
            if (MistakeCatcher == false)
            {
                return FeedAnimal();
            }
            switch (FeedChoice)
            {
                case 1:
                    FeedCats();
                    break;
                case 2:
                    FeedDogs();
                    break;
            }
            return 1;
        }

        public void FeedCats()
        {
            for (int i = 0; i < listOfCages[0].Count; i++)
            {
                if (listOfCages[0][i].IsFed != true)
                {
                    listOfCages[0][i].IsFed = true;
                }
            }
            Console.WriteLine("The cats are fed with special cat food!");
            Console.ReadLine();
        }

        public void FeedDogs()
        {
            for (int i = 0; i < listOfCages[1].Count; i++)
            {
                if (listOfCages[1][i].IsFed != true)
                {
                    listOfCages[1][i].IsFed = true;
                }
            }
            Console.WriteLine("The dogs are fed with the special formula dog food!");
            Console.ReadLine();
        }

        public int CheckTheSystem()
        {
            Console.WriteLine("Which system would you like to check?");
            Console.WriteLine("Enter 1 for cats, and 2 for dogs!");
            int systemChoice;
            bool MistakeCatcher = Int32.TryParse(Console.ReadLine(), out systemChoice);
            if (MistakeCatcher == false)
            {
                return CheckTheSystem();
            }
            switch (systemChoice)
            {
                case 1:
                    CheckCatSystem();
                    break;
                case 2:
                    CheckDogSystem();
                    break;
                default:
                    break;
            }
            return 1;
        }

        public void CheckCatSystem()
        {
            foreach (var catName in listOfCats)
            {
                Console.WriteLine(catName.Name);
                
            }
        }

        public void CheckDogSystem()
        {
            foreach (var dogName in listOfDogs)
            {
                Console.WriteLine(dogName.Name);
            }
        }

        public void FillOutAdoptionForm()
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Whats your full address?");
            string address = Console.ReadLine();
            Console.WriteLine("Whats your date of birth?");
            string dateofbirth = Console.ReadLine();
            bool isapproved = false;
            AdoptionCanidate Adoptor = new AdoptionCanidate(name, address, dateofbirth, isapproved);
            ListOfAdoptionCanidates.Add(Adoptor);
        }

        public void CheckAdoptorList()
        {
            Console.WriteLine("The number before their name is their adoptor ID!");
            foreach (var adoptors in ListOfAdoptionCanidates)
            {
                int i = 0;
                Console.WriteLine(i + " " + adoptors.Name);
                i++;
            }
        }

        public void ApproveAdoption()
        {
            
        }

        public void AdoptAnimal()
        {

        }
    }
}
