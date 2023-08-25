using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mcvey_Zander
{
    internal class Computer : IBootUp
    {
        //assigns a get and set value to the bool IsOn and the strings Brand, and Type.
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        //Makes Brand, Type, and IsOn into statements and lowercase the first word, camelcasing.
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Sets an if else statement for the IsOn statement and making it apart of PowerOnOff.
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        //Tells the program what brand and type of computer it is and if it is on.
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} computer, it is {IsOn}!";
        }
    }
}
