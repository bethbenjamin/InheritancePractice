using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Standard : Membership //states that it is derived from base class Membership
    {
        //fields
        //invisible


        //properties
        public int Cost { get; set; } //short hand for get/set values it also at the sametime creates the lowercase cost associated with Property Cost
                                      // only works when fields arent declared

        // constructors
        public Standard() // this is a default constructor meaning the () is empty
        {
            //default
        }

        public Standard(int cost) //overloaded constructor // another way of writing a constructor
        {
            Cost = cost;
        }


        //method

        public override void Activate()
        {
            if (IsActive == false) // initially when i added this it was isActive - it needs to be changed to IsActive bc it's a private method from base
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
        }

    }//end public class standard
}// end namespace
