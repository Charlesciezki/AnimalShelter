using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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
        public List<Animal> AdoptedAnimalsList = new List<Animal>();
        public List<string> animalsWithAdoptor = new List<string>();
        Random random = new Random();
        public bool hasHadShot;
        public bool hasBeenFed;
        public double AnimalShelterFunds = 0;
        public string adoptorAndAnimals;

        public AnimalShelter()
        {
            listOfCages.Add(listOfCats);
            listOfCages.Add(listOfDogs);
        }

        public void SpawnAdoptors()
        {
            List<string> adoptorsNames = new List<string> { "Tyler", "Charles", "David", "Paul" };
            List<string> adoptorsAddresses = new List<string> {"Waukesha", "Mukwonago", "Milwaukee", "Jackson"};
            List<string> adoptorsDOB = new List<string> { "Jan 23 1993", "Jun 2 1984", "Nov 11 1921", "Dec 25 2000"};
            string name;
            string address;
            string dob;
            bool isapproved = false;
            for (int i = 0; i < 5; i++)
            {

                int nameNumber = random.Next(0, 4);
                if (nameNumber == 0)
                {
                    name = adoptorsNames[0];
                }
                else if (nameNumber == 1)
                {
                    name = adoptorsNames[1];
                }
                else if (nameNumber == 2)
                {
                    name = adoptorsNames[2];
                }
                else 
                {
                    name = adoptorsNames[3];
                }

                int addressNumber = random.Next(0, 4);
                if (addressNumber == 0)
                {
                    address = adoptorsAddresses[0];
                }
                else if (addressNumber == 1)
                {
                    address = adoptorsAddresses[1];
                }
                else if (addressNumber == 2)
                {
                    address = adoptorsAddresses[2];
                }
                else 
                {
                    address = adoptorsAddresses[3];
                }

                int dateNumber = random.Next(0, 4);
                if (dateNumber == 0)
                {
                    dob = adoptorsDOB[0];
                }
                else if (dateNumber == 1)
                {
                    dob = adoptorsDOB[1];
                }
                else if (dateNumber == 2)
                {
                    dob = adoptorsDOB[2];
                }
                else
                {
                    dob = adoptorsDOB[3];
                }
                AdoptionCanidate adoptor = new AdoptionCanidate(name, address, dob, isapproved);
                ListOfAdoptionCanidates.Add(adoptor);
                
            }
        }

        public void SpawnCats()
        {
            List<string> catNames = new List<string> {"Paul", "Mittens", "Smudge", "Fifi-The Destroyer of Worlds"};
            List<string> catBreed = new List<string> {"Tabby", "Persian", "Ragdoll", "Siamese" };

            bool hasshots = false;
            bool isfed = false;
            string name;
            string breed;
            for (int i = 0; i < 5; i++)
            {
                int age = random.Next(1, 9);
                double adoptCost = random.Next(100, 351);
                int randomCatName = random.Next(0, 4);
                if (randomCatName == 0)
                {
                    name = catNames[0];
                }
                else if (randomCatName == 1)
                {
                    name = catNames[1];
                }
                else if (randomCatName == 2)
                {
                    name = catNames[2];
                }
                else
                {
                    name = catNames[3];
                }

                int randomCatBreed = random.Next(0, 4);
                if (randomCatBreed == 0)
                {
                    breed = catBreed[0];
                }
                else if (randomCatBreed == 1)
                {
                    breed = catBreed[1];
                }
                else if (randomCatBreed == 2)
                {
                    breed = catBreed[2];
                }
                else
                {
                    breed = catBreed[3];
                }
                CatClass Kitty = new CatClass(age, adoptCost, hasshots, isfed, name, breed);
                listOfCages[0].Add(Kitty);
            }
        }

        public void SpawnDogs()
        {
            List<string> dogNames = new List<string> {"Abby", "Peter", "Oreo", "Sparkles-The Breaker of Mountains"};
            List<string> dogBreeds = new List<string> {"Corgi", "Pug", "Beagle", "Russian Mountain Dog"};
            bool hasshots = false;
            bool isfed = false;
            string name;
            string breed;
            for (int i = 0; i < 5; i++)
            {
                int age = random.Next(1, 9);
                double adoptCost = random.Next(100, 951);
                int nameSelect = random.Next(0, 4);
                if (nameSelect == 0)
                {
                    name = dogNames[0];
                } else if (nameSelect == 1)
                {
                    name = dogNames[1];
                } else if (nameSelect == 2)
                {
                    name = dogNames[2];
                }
                else
                {
                    name = dogNames[3];
                }

                int breedSelect = random.Next(0, 4);
                if (breedSelect == 0)
                {
                    breed = dogBreeds[0];
                } else if (breedSelect == 1)
                { 
                    breed = dogBreeds[1];
                } else if (breedSelect == 2)
                {
                    breed = dogBreeds[2];
                }
                else
                {
                    breed = dogBreeds[3];
                }
                DogClass Doggie = new DogClass(age, adoptCost, hasshots, isfed, name, breed);
                listOfCages[1].Add(Doggie);
            }
            
        }
        public void CheckAnimalShelterFunds()
        {
            Console.WriteLine(AnimalShelterFunds);
        }
        public int ChooseAnimalToAdd()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter 1 to remove a dog");
            Console.WriteLine("Enter 2 to remove a cat");
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
            Console.ForegroundColor = ConsoleColor.Green;
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
            CheckCatSystem();
            Console.WriteLine("Enter the ID of the cat you wish to remove!");
            int catID = Convert.ToInt32(Console.ReadLine());
            listOfCages[0].RemoveAt(catID);
            Console.WriteLine("The cat list will reflect the changes made!");
            CheckCatSystem();
        }

        public void AddDog()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            CheckDogSystem();
            Console.WriteLine("Enter the ID of the dog you wish to remove!");
            int dogID = Convert.ToInt32(Console.ReadLine());
            listOfCages[1].RemoveAt(dogID);
            Console.WriteLine("The dog list will reflect the changes made!");
            CheckDogSystem();
        }

        public int GiveShots()
        {
            Console.ForegroundColor = ConsoleColor.Green;
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
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Magenta;
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
            int i = 0;
            Console.WriteLine("The number before the cats name is the cat ID");
            foreach (var catName in listOfCats)
            {
                Console.WriteLine(i + " " + catName.Name);
                i++;
            }
        }

        public void CheckDogSystem()
        {
            int i = 0;
            Console.WriteLine("The number before the dogs name is the dog ID");
            foreach (var dogName in listOfDogs)
            {                                
                Console.WriteLine(i + " " + dogName.Name);
                i++;
            }
        }

        public void FillOutAdoptionForm()
        {
            Console.ForegroundColor = ConsoleColor.White;
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

        public int CheckAdoptorList()
        {
            int i = 0;
            Console.WriteLine("The number before their name is their adoptor ID!");
            foreach (var adoptors in ListOfAdoptionCanidates)
            {                
                Console.WriteLine(i + " " + adoptors.Name);
                i++;
            }
            return 1;
        }

        public int ApproveAdoption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Would you like to veiw the adoptors and their IDs?");
            Console.WriteLine("Enter 1 for yes and enter 2 for no!");
            int seeAdoptors = Convert.ToInt32(Console.ReadLine());
            if (seeAdoptors == 1)
            {
                CheckAdoptorList();
            }
            Console.WriteLine("Please enter the adoptor ID of the person you wish to approve");
            int AdoptorIDApprove = Convert.ToInt32(Console.ReadLine());
            ListOfAdoptionCanidates[AdoptorIDApprove].IsApproved = true;
            Console.WriteLine(ListOfAdoptionCanidates[AdoptorIDApprove].Name + " has been approved!");
            return 1;
        }

        public int AdoptAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which kind of animal would you like to adopt?");
            Console.WriteLine("Enter 1 for cat and enter 2 for dog");
            int whichAnimal = Convert.ToInt32(Console.ReadLine());
            if (whichAnimal == 1)
            {
                AdoptaCat();
            } else if (whichAnimal == 2)
            {
                AdoptaDog();
            }
            else
            {
                return AdoptAnimal();
            }
            return 1;
        }

        public int AdoptaCat()
        {
            CheckAdoptorList();
            Console.WriteLine("Who is adopting?");
            int adoptor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You've selected " + ListOfAdoptionCanidates[adoptor].Name);

            CheckCatSystem();
            Console.WriteLine("Choose the ID of the cat you wish to adopt");
            int AdoptCat = Convert.ToInt32(Console.ReadLine());


            adoptorAndAnimals = ListOfAdoptionCanidates[adoptor].Name + " adopted " + listOfCages[0][AdoptCat].Name;
            Console.WriteLine(adoptorAndAnimals);
            animalsWithAdoptor.Add(adoptorAndAnimals);

            AdoptedAnimalsList.Add(listOfCages[0][AdoptCat]);
            AnimalShelterFunds = AnimalShelterFunds + listOfCages[0][AdoptCat].AdoptCost;
            listOfCages[0].RemoveAt(AdoptCat);
            Console.WriteLine("The cat system will reflect the changes made!");
            CheckCatSystem();
            return 1;
        }

        public int AdoptaDog()
        {
            CheckAdoptorList();
            Console.WriteLine("Who is adopting?");
            int adoptor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You've selected " + ListOfAdoptionCanidates[adoptor].Name);

            CheckDogSystem();
            Console.WriteLine("Choose the ID of the dog you wish to adopt!");
            int AdoptDog = Convert.ToInt32(Console.ReadLine());

            adoptorAndAnimals = ListOfAdoptionCanidates[adoptor].Name + " adopted " + listOfCages[1][AdoptDog].Name;
            Console.WriteLine(adoptorAndAnimals);
            animalsWithAdoptor.Add(adoptorAndAnimals);

            AdoptedAnimalsList.Add(listOfCages[1][AdoptDog]);
            AnimalShelterFunds = AnimalShelterFunds + listOfCages[1][AdoptDog].AdoptCost;
            listOfCages[1].RemoveAt(AdoptDog);
            Console.WriteLine("The dog system will reflect the changes made!");
            CheckDogSystem();
            return 1;
        }
    }
}
