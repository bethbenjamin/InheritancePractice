using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Standard gymMember1 = new Standard(100);
            VIP gymMember2 = new VIP();

            gymMember1.Activate();
            gymMember2.Activate();

            
        }
    }
}
