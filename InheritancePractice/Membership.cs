using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Membership //remember to change this to public 
    {
        //fields
        private int memberID; //membership member ID
        private bool isActive; //is the membership active?


        //properties
        public int MemberID
        {
            get { return this.memberID; }  // we are getting the value
            set { this.memberID = value; } // we are setting the value
        }

        public bool IsActive
        {
            get { return this.isActive; }  // we are getting the value
            set { this.isActive = value; } // we are setting the value
        }
        
       
        //constructors
        public Membership()
        {
            //default
        }
        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID; //field
            this.isActive = isActive; //parameter
        }

        public virtual void Activate() // this has the virtual keyword which gives any other classes permission to adjust it or 'override' down the road
        {
            if (isActive == false)
            {
                isActive = true;
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }
    }//end class
}//end namespace
