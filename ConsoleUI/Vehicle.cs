using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public  int year { get; set; }
        public  string make { get; set; }
        public  string model { get; set; }

        public bool hasTrunk { get; set; }


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The vehicle is in Drive!");
        }

    }
}