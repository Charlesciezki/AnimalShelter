using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimalShelter
{
    public class CatClass : Animal
    {

        public CatClass(int age, double adoptcost, bool hasshots, bool isfed, string name, string breed)
        {
            Age = age;
            AdoptCost = adoptcost;
            HasShots = hasshots;
            IsFed = isfed;
            Name = name;
            Breed = breed;
        }

    }
}
