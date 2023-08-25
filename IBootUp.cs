using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mcvey_Zander
{
    internal interface IBootUp
    {
        //Turns on the "Computer" and says if it is shutting down or turning on from the PowerOnOff command.
        public bool IsOn { get; set; }

        public void PowerOnOff();



    }
}
