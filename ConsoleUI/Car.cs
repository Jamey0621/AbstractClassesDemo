using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car: Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {make} can drive!");
        }
    }
}
