using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimalShelter
{
    public class AdoptionCanidate
    {
        public string Name;
        public string Address;
        public string DateOfBirth;
        public bool IsApproved;

        public AdoptionCanidate(string name, string address, string DOB, bool isapproved)
        {
            Name = name;
            Address = address;
            DateOfBirth = DOB;
            IsApproved = isapproved;
        }

    }
}
