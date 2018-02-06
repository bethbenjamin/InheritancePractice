using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class VIP : Membership //pairing with base class membership
    {
        //fields
        //invisible

        //properties
        public bool IsSwanky { get; set; } //creating a field behind the scenes called isSwanky that has been get set by this shorthand


        //constructors
        public VIP()
        {
            //default constructor 
        }
        public VIP(bool isSwanky)
        {
            this.IsSwanky = isSwanky;  
        }

        //methods

        public override void Activate()
        {
            IsSwanky = true;
            if (IsActive == false) // initially when i added this it was isActive - it needs to be changed to IsActive bc it's a private method from base
            {
                IsActive = true;
                Console.WriteLine("Your are now a big deal.");
            }
            else
            {
                Console.WriteLine("You're already a big deal.");
            }
        }//end public override void Activate()


    }//end class VIP
}//end namespace
