using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimalShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool rungame = true;
            MainInterface TheMainMenu = new MainInterface();
            while (rungame)
            {
                
                TheMainMenu.MainMenu(); 
            }           
        }
    }
}
