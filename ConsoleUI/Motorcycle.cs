using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
    
        public bool hasSideCart { get; set; }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Were in drive!");
        }
    }
}
